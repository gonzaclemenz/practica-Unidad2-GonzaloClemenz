using practica_Unidad2_GonzaloClemenz;

public class ServicioChat
{
    private List<Usuario> usuarios = new();
    private List<Chat> chats = new();
    private List<Notificaciones> notificaciones = new();
    private int proximoIdChat = 1;
    private int proximoIdMensaje = 1;
    private int proximoIdNotificacion = 1;

    public void AgregarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public void AbrirChat(int emisorId, int receptorId, string tituloChat)
    {
        var emisor = usuarios.FirstOrDefault(u => u.Id == emisorId);
        var receptor = usuarios.FirstOrDefault(u => u.Id == receptorId);

        if (emisor == null || receptor == null) return;

        var chat = new Chat
        {
            Id = proximoIdChat++,
            Titulo = tituloChat
        };

        if (receptor.Amigos.Contains(emisorId))
        {
            chat.Estado = EstadoChat.Abierto;
            chat.Mensajes.Add(new Mensaje
            {
                Id = proximoIdMensaje++,
                FechaEnvio = DateTime.Now,
                Texto = $"El usuario {emisor.Nickname} ha iniciado un chat"
            });

            notificaciones.Add(new NotiNuevoChat
            {
                Id = proximoIdNotificacion++,
                Titulo = "Nuevo Chat Iniciado",
                Descripcion = "Un amigo ha iniciado un nuevo chat contigo.",
                UsuarioReceptorId = receptorId,
                Categoria = CategoriaNotificacion.NuevoChat,
                UsuarioIniciadorId = emisorId,
                ChatId = chat.Id
            });
        }
        else
        {
            chat.Estado = EstadoChat.EnProceso;
            chat.Mensajes.Add(new Mensaje
            {
                Id = proximoIdMensaje++,
                FechaEnvio = DateTime.Now,
                Texto = $"El usuario {emisor.Nickname} quiere comunicarse contigo, hasta no aceptarlo como amigo no podrá escribir"
            });

            notificaciones.Add(new NotiSoliAmistad
            {
                Id = proximoIdNotificacion++,
                Titulo = "Solicitud de Amistad",
                Descripcion = "Un usuario quiere comunicarse contigo.",
                UsuarioReceptorId = receptorId,
                Categoria = CategoriaNotificacion.SolicitudAmistad,
                FechaExpiracion = DateTime.Now.AddDays(7),
                UsuarioEmisorId = emisorId,
                ChatId = chat.Id
            });
        }

        chats.Add(chat);
    }

    public void EnviarMensaje(int chatId, string texto)
    {
        var chat = chats.FirstOrDefault(c => c.Id == chatId);
        if (chat == null || chat.Estado != EstadoChat.Abierto) return;

        chat.Mensajes.Add(new Mensaje
        {
            Id = proximoIdMensaje++,
            FechaEnvio = DateTime.Now,
            Texto = texto
        });
    }
}
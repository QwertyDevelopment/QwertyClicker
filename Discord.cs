using DiscordRPC;

namespace QwertyClicker
{
    public partial class Discord
    {

        public string ?client_id;
        public DiscordRpcClient ?RPC;

        public Discord(string client_id)
        {
            this.client_id = client_id;
        }

        public void Start()
        {
            try
            {
                this.RPC = new DiscordRpcClient(this.client_id);
                RPC.Initialize();
                RPC.SetPresence(new RichPresence()
                {
                    Details = "QwertyClicker",
                    State = "Autoclicking...",
                    Assets = new Assets()
                    {
                        LargeImageKey = "qwerty_logo",
                        LargeImageText = "Qwerty Development",
                        SmallImageKey = "qwerty_clicker_logo",
                        SmallImageText = "QwertyClicker",
                    }
                });
                Logger.info("Started: Discord Rich Presence!");
            } catch
            {
                Logger.error("Unable to start discord rich presence... Possible discord is not opened or connection problems...");
            }
        }

        public void Stop()
        {
            if (this.RPC != null)
            {
                RPC.Invoke();
            } else
            {
                Logger.error("Unable to stop discord rich presence: DiscordRPC is not initilized yet.");
            }
        }
    }
}
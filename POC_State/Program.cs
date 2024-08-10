using POC_State.Models;

class Program
{
    public static void Main(String[] args)
    {
        MusicPlayer player = new MusicPlayer();

        player.PressPlay();
        player.PressPause(); 
        player.PressPause();  
        player.PressPlay();   
    }
}

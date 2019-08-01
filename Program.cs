/*
This program is parody and not intended to be distributed for financial gain.
The song is My Little Rooster (1960) by Almeda Riddle.
Add your animal class in Animal.cs and animal to the animals list in Song.cs to continue the chain forever.
Try a bunny. Try a cat.
*/
using LittleRooster;
class Program
    {
    static void Main(string[] args)
    {
        Song newSong = new Song();
        newSong.StartSong();
        System.Environment.Exit(1);
    }
}
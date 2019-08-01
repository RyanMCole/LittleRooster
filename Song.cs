using System;
using System.Speech.Synthesis;
using System.Drawing;
using Console = Colorful.Console;
using System.Linq;
using System.Collections.Generic;

namespace LittleRooster
{
    class Song
    {
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        //synthesizer.Volume = 100;  // 0...100
        //synthesizer.Rate = -2;     // -10...10

        public int numAnimals;
        public string firstSentence, secondSentence, sAnimalSound, firstWord;

        public void StartSong()
        {
            Console.Title = "LittleRooster";

            //Create old lady voice
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);

            //Animal list. Add your new animal here.
            var animals = new List<IAnimal>();
            animals.Add(new Rooster { });
            animals.Add(new Hen { });
            animals.Add(new Duck { });
            animals.Add(new Guinea { });
            animals.Add(new Pig { });

            numAnimals = animals.Count();

            for (int paragraph = 0; paragraph < numAnimals; paragraph++)
            {
                //New animal introduction
                if (paragraph > 0)
                    firstWord = "And ";
                else
                    firstWord = "";

                Console.BackgroundColor = Color.Black;
                Console.ForegroundColor = Color.LightGray;
                Console.Clear();
                firstSentence = String.Format("{0}I love my little {1} and my {1} loves me.", firstWord, animals[paragraph].animalType());
                TextAndVoice(firstSentence);

                secondSentence = String.Format("I'm gonna cherish that {0} 'neath a green bay tree.", animals[paragraph].animalType());
                TextAndVoice(secondSentence);

                //Animal sound chorus
                Console.BackgroundColor = Color.DeepSkyBlue;
                for (int animalSeq = paragraph; animalSeq >= 0; animalSeq--)
                {
                    Console.Clear();
                    Console.ForegroundColor = Color.FromName(animals[animalSeq].color());
                    Console.WriteLine(animals[animalSeq].image());
                    Console.ForegroundColor = Color.Black;
                    sAnimalSound = String.Format("My little {0} goes {1}", animals[animalSeq].animalType(), animals[animalSeq].sound());
                    TextAndVoice(sAnimalSound);
                }
            }
        }

        public void TextAndVoice(string text)
        {
            if (Console.WindowWidth - text.Length > 0)
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);

            Console.WriteLine(text);
            synthesizer.Speak(text);
        }

    }
}


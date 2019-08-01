namespace LittleRooster
{
    interface IAnimal
    {
        string animalType();
        string sound();
        string image();
        string color();
    }

    class Rooster : IAnimal
    {
        public string animalType() => "rooster";

        public string sound() => "cock-a-doodle-doooooooo, doodle-doo, doodle-doo!";

        public string image()
        {
            return @"
            		            ~-.
                    ,,,;            ~-.~-.~-
                   (.../           ~-.~-.~-.~-.~-.
                   } o~`,         ~-.~-.~-.~-.~-.~-.
                   (/    \      ~-.~-.~-.~-.~-.~-.~-.
                    ;    \    ~-.~-.~-.~-.~-.~-.~-.
                   ;     {_.~-.~-.~-.~-.~-.~-.~
                  ;:  .-~`    ~-.~-.~-.~-.~-.
                 ;.: :'    ._   ~-.~-.~-.~-.~-
                  ;::`-.    '-._  ~-.~-.~-.~-
                   ;::. `-.    '-,~-.~-.~-.
                    ';::::.`''-.-'
                      ';::;;:,:'
                         '||'
                         / |
                       ~` ~''
                      ";
        }

        public string color() => "Red";
    }

    class Duck : IAnimal
    {
        public string animalType() => "duck";

        public string sound() => "quack quack.";

        public string image()
        {
            return @"
                                             ___
                                         ,-''   `.
                                       ,'  _   e )`-._
                                      /  ,' `-._<.===-'
                                     /  /
                                    /  :
                        _.--.__    /   :
           (`._    _.-''       '--'    |
           <_  `-''                     \
            <`-                          :
             (__   <__.                  :
               `-.   '-.__.      _.'    /
                  \      `-.__,-'    _,'
                   `._    ,    /__,-'
                      ''._\__,'< <____
                           | |  `----.`.
                           | |        \ `.
                           : |___      \-``
                           \   --<
                            `.`.<
                              `-'
                       ";
        }

        public string color() => "FloralWhite";
    }

    class Pig : IAnimal
    {
        public string animalType() => "pig";

        public string sound() => "ump ump.";

        public string image()
        {
            return @"
                                             )\   /|
                                          .-/'-|_/ |
                       __            __,-' (   / \/          
                   .-''  ''-..__,-'''          -o.`-._   
                  /                                   '/
          *--._ ./                                 _.-- 
                |                              _.-' 
                :                           .-/   
                 \                       )_ /
                  \                _)   / \(
                    `.   /-.___.---'(  /   \\
                     (  /   \\       \(     L\
                      \(     L\       \\
                       \\              \\
                        L\              L\
            ";
        }

        public string color() => "Pink";
    }

    class Hen : IAnimal
    {
        public string animalType() => "hen";

        public string sound() => "cluck cluck.";

        public string image()
        {
            return @"                        
                   ,~.
                ,-'__ `-,
               {,-'  `. }              ,')
              ,( a )   `-.__         ,',')~,
             <=.) (         `-.__,==' ' ' '}
               (   )                      /
                `-'\   ,                  )
                    |  \        `~.      /
                    \   `._        \    /
                     \     `._____,'   /
                      `-.            ,'
                         `-.      ,-'
                            `~~~~'
                            //_||
                         __//--'/`          
                       ,--'/`  '
                          '
            ";
        }

        public string color() => "Brown";
    }

    class Guinea : IAnimal
    {
        public string animalType() => "guinea";

        public string sound() => "paderack.";

        //Yes, I know the song is referring to a guineafowl and not a guinea pig, but I couldn't find fowl ASCII art. Plus it's cute.
        public string image()
        {
            return @"
                   _           _
                (`-`:-'```'-:`-`)
                 \.'         './
                 /             \
                 ;   0     0   ;
                /| =         = |\
               ; \   '._Y_.'   / ;
              ;   `-._ \|/ _.-'   ;
             ;        `'''`        :
             ;    `''-.   .-''`    :
             /;  '--._ \ / _.--   ;\
            :  `.   `/|| ||\`   .'  :
             '.  '-._       _.-'   .'       
             (((-'`  `'''''`   `'-)))
                      ";
        }

        public string color() => "Yellow";
    }
}

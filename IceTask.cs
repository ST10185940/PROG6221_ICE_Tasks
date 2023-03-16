using System;

namespace ICETask.cs{

    class Scripts{
                int[] lecs = new int[numLecs];  // stores number of scripts to marks for each lec
                double[] hrs = new Double[numLecs]; // stores the number of hours each lec will spend marking
                double[] mins = new Double[numLecs]; // stores the number of mins each lec will spend marking

        static void main (String [] args){
            entry();
            ditribute();
        }

        static void entry(){

            do {
            System.Console.WriteLine("Enter the total number of scripts to be marked");
              int scripts = Console.ReadLine();
            }
            while(scripts < 0);

            do{
            System.Console.WriteLine("enter the number of questions in each test ");
                int questions = Console.ReadLine();
            }while(!(questions >= 1 || questions <= 10));
            
            do{
                System.Console.WriteLine("enter the subtotal of each question");
                double sub = Console.ReadLine();
                System.Console.WriteLine("the number of lecturers who will be marking ");
                int numLecs = Console.ReadLine();

            }while(sub < 0 || Lecs  > 0 );
        }

        static void distribute(){
            int toMark,timeToMark,hrs,mins;
            remains = (scripts%50);

            if (reamins == 0){
               toMark= (scripts/50);
               timeToMark = (questions*2)*toMark;
               hrs = (timeToMark/3600); //changes seconds in hrs 
               mins = (timeToMark%3600) *60 ; //  gets remainders of hrs and changes into mins
               display();}

               else
               {
                foreach( int tut in lecs){
                 Lecs [tut+1] += remains;
                 hrs[tut+1] = (questions*2)*Lecs[tut+1]/3600;
                 mins[tut+1] = ((questions*2)*Lecs[tut+1]/3600)*60;     
                 }
               }
   
        }
        static void display(){
                System.Console.WriteLine($"Scriptes per Lecturer:{toMark}");
                System.Console.WriteLine($"Lectureres will spend an average of {hrs}hrs and {mins}mins marking their scripts");
        }

        static void displayfull(){
                foreach(int l in lecs)
                {
                    System.Console.WriteLine($"lectrure{l} will mark {lecs[l]} scripts and will spend {hrs[l]}hrs and {mins[l]} minutes marking scripts ");
                }
        }
    }
}
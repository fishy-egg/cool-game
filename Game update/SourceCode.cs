using System;

namespace Game
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dungeon Keeper";
            begin:
            Console.WriteLine("Cheatcode #" + "\n" + "If unsure or don't have one type in '0' ");
            int cheatCode = Convert.ToInt32(Console.ReadLine());
            if(cheatCode == 0){

            }else if(cheatCode == 1234){
                goto mainMenu;
            }else if(cheatCode == 12345){
                goto startOfTest;
            }else if(cheatCode == 1111){
                
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid cheatcode # try again or type 0 to continue");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(7000);
                goto begin;
            }
            Console.Clear();
            Console.WriteLine("Hello there!");
            Console.WriteLine("My name is Sir M. Paul ");
            Console.WriteLine("I am a 22-year-old wizard and I like upcycling and collecting potions.");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine("I am a kind and reliable leader and I will teach you all about the life of being a Dungeon Keeper.");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Pleasure to meet you " + userName + ", would you like to persue your task?");
            Console.WriteLine("(1 = Yes 0 = No)");
            int yesNo = Convert.ToInt32 (Console.ReadLine());
            if(yesNo == 1){
                Console.WriteLine("So you have chosen to continue.");
            }
            else{
                System.Environment.Exit(0);
            }
            Console.WriteLine("Let's get you in tip top shape for what your going to do");
            Console.WriteLine("Press SPACE to TELEPORT");
            Console.ReadKey();
            Console. ForegroundColor = ConsoleColor. DarkGreen;
            Console.WriteLine("TRAVELING TO TRANING ACADEMY");
            Console.Write("[█");
            System.Threading.Thread.Sleep(156);
            Console.Write("██");
            System.Threading.Thread.Sleep(831);
            Console.Write("█");
            System.Threading.Thread.Sleep(1020);
            Console.Write("█");
            System.Threading.Thread.Sleep(192);
            Console.Write("█");
            System.Threading.Thread.Sleep(2194);
            Console.Write("██");
            System.Threading.Thread.Sleep(1274);
            Console.Write("█");
            System.Threading.Thread.Sleep(4123);
            Console.Write("██] 1OO% Complete!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" ");
            Console.WriteLine("TRAVEL SUCCSESSFUL");
            Console. ForegroundColor = ConsoleColor. White;
            Console.WriteLine("So let's see what you need to learn.");
            Console. ForegroundColor = ConsoleColor. DarkRed;
            Console.WriteLine("QUIZ TIME!!");
            startOfTest:
            System.Threading.Thread.Sleep(1000);
            Console. ForegroundColor = ConsoleColor. White;
            int quizPoint = 0;
            Console.WriteLine("Press SPACE to Start!");
            Console.ReadKey();
            Console.WriteLine("Please answer in the number of the answer");
            Console.WriteLine("Question 1");
            Console.WriteLine("How many goblins spawn in a wave?");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 25");
            Console.WriteLine("3. 50");
            Console.WriteLine("4. 100");
            int q1 = Convert.ToInt32(Console.ReadLine());
            if(q1 == 2){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;

            }else{
             Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct one was 2.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 2");
            Console.WriteLine("How many waves are there in a dungeon?");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 20");
            Console.WriteLine("3. 15");
            Console.WriteLine("4. 25");
            int q2 = Convert.ToInt32(Console.ReadLine());
            if(q2 == 1){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct one was 1.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 3");
            Console.WriteLine("Which is the most powerful attack in the game?");
            Console.WriteLine("1. Blast Bomb");
            Console.WriteLine("2. Atonimus Apples");
            Console.WriteLine("3. Smelly Spells");
            Console.WriteLine("4. Potion of Poison");
            int q3 = Convert.ToInt32(Console.ReadLine());
            if(q3 == 3){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer was 3.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 4");
            Console.WriteLine("How many objects can you stumble across whilst walking?");
            Console.WriteLine("1. ~100");
            Console.WriteLine("2. ~200");
            Console.WriteLine("3. ~1000");
            Console.WriteLine("4. ~2000");
            int q4 = Convert.ToInt32(Console.ReadLine());
            if(q4 == 2){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer was 2.");
                Console. ForegroundColor = ConsoleColor. White;
               }
               Console.WriteLine("Press SPACE to continue");
               Console.ReadKey();
               Console.WriteLine("Question 5");
               Console.WriteLine("How many different types of goblins are there?");
               Console.WriteLine("1. 2");
               Console.WriteLine("2. 5");
               Console.WriteLine("3. 10");
               Console.WriteLine("4. 15");
               int q5 = Convert.ToInt32(Console.ReadLine());
               if(q5 == 2){
                   Console. ForegroundColor = ConsoleColor. Green;
                   Console.WriteLine("Correct!");
                   Console. ForegroundColor = ConsoleColor. White;
                   quizPoint ++;
               }else{
                   Console. ForegroundColor = ConsoleColor. Red;
                   Console.WriteLine("Incorrect! The correct answer was 2.");
                   Console. ForegroundColor = ConsoleColor. White;
               }
               Console.WriteLine("Press SPACE to continue");
               Console.ReadKey();
            Console.WriteLine("Question 6");
            Console.WriteLine("What is the most important place in a Galaxy?");
            Console.WriteLine("1. The Shopping Mall");
            Console.WriteLine("2. Earth");
            Console.WriteLine("3. Trevlasty Jeruvian Planet");
            Console.WriteLine("4. The Cave");
            int q6 = Convert.ToInt32(Console.ReadLine());
            if(q6 == 4){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer was 4.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 7");
            Console.WriteLine("How do you craft a stepping stone?");
            Console.WriteLine("1. A Rock");
            Console.WriteLine("2. Two Rocks and a Hammer");
            Console.WriteLine("3. A Rock and a Hammer");
            Console.WriteLine("4. A bundle of Rocks");
            int q7 = Convert.ToInt32(Console.ReadLine());
            if(q7 == 3){
               Console. ForegroundColor = ConsoleColor. Green;
               Console.WriteLine("Correct!");
               Console. ForegroundColor = ConsoleColor. White; 
               quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer was 3.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 8");
            Console.WriteLine("How many diffrent sizes of backpacks are there?");
            Console.WriteLine("1. 1 Medium");
            Console.WriteLine("2. 2 Small & Medium");
            Console.WriteLine("3. 3 Small, Medium & Large");
            Console.WriteLine("4. 4 Small, Medium, Large & XLarge");
            int q8 = Convert.ToInt32(Console.ReadLine());
            if(q8 == 3){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Correct!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer is 3.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Question 9");
            Console.WriteLine("How do you craft a backpack?");
            Console.WriteLine("1. 2 Leather slices & 1 String");
            Console.WriteLine("2. 1 Leather slice & 2 String");
            Console.WriteLine("3. 3 Leather slices");
            Console.WriteLine("4. You can't");
            int q9 = Convert.ToInt32(Console.ReadLine());
            if(q9 == 4){
               Console. ForegroundColor = ConsoleColor. Green;
               Console.WriteLine("Correct!");
               Console. ForegroundColor = ConsoleColor. White;
               quizPoint++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! The correct answer is 4.");
                Console. ForegroundColor = ConsoleColor. White;
            }
            Console.WriteLine("Press SPACE to continue");
            Console.ReadKey();
            Console.WriteLine("Final question!");
            Console.WriteLine("Question 10");
            Console.WriteLine("True or False. " + "\n" + " We are constantly working on this project");
            bool q10 = Convert.ToBoolean(Console.ReadLine());
            if(q10 == false){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Corect!");
                Console. ForegroundColor = ConsoleColor. White;
                quizPoint ++;
            }else{
                Console. ForegroundColor = ConsoleColor. Red;
                Console.WriteLine("Incorrect! It was actually False!");
                Console. ForegroundColor = ConsoleColor. White;
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You got " + quizPoint + "/10!");
            if(quizPoint == 10){
                Console. ForegroundColor = ConsoleColor. Green;
                Console.WriteLine("Congratulations! You got 10/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
            }else if(quizPoint == 9){
                Console. ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Congratulations! You got 9/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
            }else if(quizPoint == 7){
                Console. ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Good Job! You got 7/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
            }else if(quizPoint == 6){
                Console. ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Yay! You got 6/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
            }else if(quizPoint == 5){
                Console. ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Well done! You got 5/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
            }else if(quizPoint == 4){
                Console. ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wow! You got 4/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
                Console.WriteLine("Almost. Try again.");
                Console.WriteLine("Press SPACE to try again.");
                Console.ReadKey();
                goto startOfTest;
            }else if(quizPoint == 3){
                Console. ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You're adequate! You got 3/10 possible points!");
                Console. ForegroundColor = ConsoleColor. White;
                Console.WriteLine("Let's try it again.");
                Console.WriteLine("Press SPACE to try again.");
                goto startOfTest;
            }else if(quizPoint == 1){
                Console. ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You're not so good... 1/10...");
                Console. ForegroundColor = ConsoleColor. White;
                Console.WriteLine("Let's try this again.");
                Console.WriteLine("Press SPACE to try again.");
                goto startOfTest;
            }else if(quizPoint == 0){
                Console. ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Did you even try... No questions right. :(");
                Console. ForegroundColor = ConsoleColor. White;
                Console.WriteLine("Let's try this again." + "\n" + "Hopefully you learnt a thing or two");
                Console.WriteLine("Press SPACE to try again.");
                goto startOfTest;
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Now with that out of the way let's get onto the real game!");
            mainMenu:
            Console.Clear();
            Console.WriteLine("===Main Menu===");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game (Doesn't work. YET)");
            Console.WriteLine("3. Settings (Work In Progress)");
            int mainMenu = Convert.ToInt32(Console.ReadLine());
            if(mainMenu == 1){
                Console.WriteLine("Let's get on to it!");
                Console.WriteLine("1. ");
            }else if(mainMenu == 2){
                Console.Clear();
                Console.WriteLine("This is a work in progress." + "\n" + "Come back later or upgrade your version to see more!");
                System.Threading.Thread.Sleep(5000);
                goto mainMenu;
            }else if(mainMenu == 3){
                settings:
                Console.Clear();
                Console.WriteLine("===Settings===");
                Console.WriteLine("");
                Console.WriteLine("Type in the number of the setting you want to change.");
                Console.WriteLine("1. Text Colour");
                Console.WriteLine("2. Background Colour");
                int settingSelect = Convert.ToInt32(Console.ReadLine());
                if(settingSelect == 1){
                    Console.Clear();
                    Console.WriteLine("1. Red" + "\n" + "2. Orange" + "\n" + "3. Yellow" + "\n" + "4. Green" + "\n" + "5. Light Blue" + "\n" + "6. Blue" + "\n" + "7. Dark Blue" + "\n" + "8. Purple" + "\n" + "9. Dark Purple" + "\n" + "10. Grey" + "\n" + "11. Dark Grey" + "\n" + "12. Black (Isn't recommended against a Black Backround)" + "\n" + "13. White (Default)");
                
                int textColour = Convert.ToInt32(Console.ReadLine());
                    if(textColour == 1){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 2){
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 3){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 4){
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 5){
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 6){
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 7){
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 8){
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 9){
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 10){
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 11){
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Text colour changed succsesfully!");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(textColour == 12){
                        Console.WriteLine("Are you sure you want to change the Text colour to Black? (Text will be invisible unless Background colour isn't Black!)");
                        Console.WriteLine("Type '1' to continue. Type '0' to go back");
                        int blackTextConfirm = Convert.ToInt32(Console.ReadLine());
                        if(blackTextConfirm == 1){
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Text colour changed succsesfully!");
                            System.Threading.Thread.Sleep(4000);
                            goto settings;
                        }else{
                            goto settings;
                        }
                    }else if(textColour == 13){
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Text colour changed succsesfully!");
                        goto settings;
                    }
                }else if(settingSelect == 2){
                    Console.Clear();
                    Console.WriteLine("1. Red" + "\n" + "2. Orange" + "\n" + "3. Green" + "\n" + "4. Light Blue" + "\n" + "5. Blue" + "\n" + "6. Dark Blue" + "\n" + "7. Purple" + "\n" + "8. Grey" + "\n" + "9. Dark Grey" + "\n" + "10. Black (Default)");
                    int backgroundColour = Convert.ToInt32(Console.ReadLine());

                    if(backgroundColour == 1){
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Background colour changed succsesfully");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }else if(backgroundColour == 2){
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Background colour changed succsesfully");
                        System.Threading.Thread.Sleep(4000);
                        goto settings;
                    }
                
                }
                
            }
            Console.ReadKey();
            Console.WriteLine("The End! This is all the time that I had for.");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }
    
    }
}
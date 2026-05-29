using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace LOL
{//start of namespace
    public class user_name
    {//start of n
        public string submit_name(TextBox user_name, ListView chats)
        {//start of

            //temp variables 
            string filename = "user_names.txt";

            //check if the filename exists or not , then auto create
            if (!File.Exists(filename))
            {
                //auto create the file using AppendAllText() function
                File.AppendAllText(filename, "auto_create\n");

            }//end 

            //temp variables
            string name = user_name.Text.ToString();

            //remove spaces at beginning and end
            name = name.Trim();

            //check if textbox is empty
            if (string.IsNullOrWhiteSpace(name))
            {
                error_method("ChatBot", "Please re-enter your username.", chats);

                user_name.Clear();
                user_name.Focus();

                return "";
            }

            //check if username contains anything other than letters
            if (!name.All(char.IsLetter))
            {
                error_method("ChatBot", "Please enter the username using letters only.", chats);

                user_name.Clear();
                user_name.Focus();

                return "";
            }

            bool found = check_name(name);

            //check if the user is found or not and write the name in a text file
            if (!found)
            {//start of if
                //write the name in a text file
                File.AppendAllText(filename, name + "\n");
                //then welcome the user
                error_method("ChatBot", "Hey " + name + "  welcome to AI cybersecurity", chats);

            }//end of if
            else
            {//start of else

                //welcome the user back
                error_method("ChatBot ", "Hey " + name + " welcome back, how can i help you today", chats);


            }//end of else


            //return name
            return name;



        }//end of
        //
        //method to check name of the user
        private Boolean check_name(string name)
        {//start

            //temp variable
            string filename = "user_names.txt";

            bool found_name = false;


            //store or get all the names in the text file and store in an 1D array
            string[] names = File.ReadAllLines(filename);

            //foreach to search the name of the user
            foreach (string name_found in names)
            { //start of loop

                //if statement to check for the username
                if (name_found.ToLower() == name.ToLower())
                {//start if

                    //found_name set to true
                    found_name = true;

                }//end of if

            }//end of the loop





            //return the status of found or not [ true or false ]
            return found_name;

        }//end check method



        //error method
        private void error_method(string name, string message, ListView chats)
        {//star of error mehtod

            // Create a border for chats
            Border messageBorder = new Border
            {
                Margin = new Thickness(0, 2, 0, 2),
                Padding = new Thickness(5, 3, 5, 3),
                CornerRadius = new CornerRadius(5)
            };

            // Set different background for user vs bot
            if (name.ToLower().Contains("chatbot") || name.ToLower().Contains("chat"))
            {
                // ChatBot = Light Grey
                messageBorder.Background = Brushes.LightGray;
            }
            else
            {
                // User = Purple
                messageBorder.Background = Brushes.Plum;
            }

            //remove borders
            messageBorder.BorderThickness = new Thickness(0);

            TextBlock messageText = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(2)
            };

            // Set color based on sender
            Brush nameColor = (name.ToLower().Contains("chatbot") || name.ToLower().Contains("chat")) ?
                              Brushes.Gray : Brushes.Purple;
            //default message color
            Brush messageColor = Brushes.Black;

            //make error/fallback messages red
            if (message.Contains("How are you") ||
                message.Contains("I don't understand") ||
                message.Contains("Please enter") ||
                message.Contains("I couldn't") ||
                message.Contains("My apologies"))
            {
                messageColor = Brushes.Red;
            }



            messageText.Inlines.Add(new Run
            {
                Text = name + ": ",
                Foreground = nameColor,
                FontWeight = FontWeights.Bold
            });

            messageText.Inlines.Add(new Run
            {
                Text = message,
                Foreground = messageColor
            });

            messageBorder.Child = messageText;
            chats.Items.Add(messageBorder);

        }//end of error method




    }


}
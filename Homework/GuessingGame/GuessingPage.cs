using System;
using Xamarin.Forms;

namespace GuessingGame
{
    public class GuessingPage : ContentPage
    {
        private GuessingGame game;
        private Entry guessEntry;
        private Label triesLabel;

        public GuessingPage()
        {
            game = new GuessingGame();
          
            //Label
            Label directionsLabel = new Label();
            directionsLabel.Text = "I am thinking of a number between " + GuessingGame.LowerBoundary + " and " + GuessingGame.UpperBoundary;
            directionsLabel.HorizontalOptions = LayoutOptions.Center;
            directionsLabel.FontAttributes = FontAttributes.Bold;

            //Entry
            guessEntry = new Entry();
            guessEntry.Placeholder = "Enter a number";

            //Button
            Button guessButton = new Button();
            guessButton.Text = "Guess";
            guessButton.Clicked += GuessButton_Clicked;

            //Label
            triesLabel = new Label();
            triesLabel.FontAttributes = FontAttributes.Italic;
            updateTriesLabel();


            Content = new StackLayout
            {
                Padding = 20,
                Children = {
                    directionsLabel,
                    guessEntry,
                    guessButton,
                    triesLabel

                }
            };
        }

        private void GuessButton_Clicked(object sender, EventArgs e)
        {
            //Are we out of tries?
            if (game.Tries <= 0)
            {
                DisplayAlert("Out of Tries", "Sorry, you are out of tries. Game over.", "Okay");
                return;
            }

            int guessedNumber;
            if (int.TryParse(guessEntry.Text, out guessedNumber))
            {
                try
                {
                    if (game.Guess(guessedNumber))
                    {
                        DisplayAlert("You Win!", "The hidden number was " + guessedNumber, "Okay");
                    }
                    else
                    {
                        DisplayAlert("Incorrect Guess", "You failed to guess the hidden number. Try again.", "Okay");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    DisplayAlert("Invalid Guess", ex.Message, "Okay");
                }
                updateTriesLabel();
                //clear entry
                guessEntry.Text = "";
            }
            else
            {
                DisplayAlert("Invalid Entry", "The information you enter must be a valid number", "Okay");
            }
        }
        private void updateTriesLabel()
        {
            triesLabel.Text = "Tries: " + game.Tries;
        }
    }
}

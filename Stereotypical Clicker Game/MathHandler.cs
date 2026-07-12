using System;
using Stereotypical_Clicker_Game.ClickHandler;
namespace Stereotypical_Clicker_Game
{
    public class MathHandler
    {
        // Link to the ClickHandler to math
        public ClickHandler.ClickHandler GameClickHandler { get; set; } = default!;

        public void Initialize()
        {
            // makes sure ClickHandler and Math are joined
            if (GameClickHandler == null)
            {
                // if not linked, error
                System.Diagnostics.Debug.WriteLine("ClickHandler is not linked to MathHandler");

            }
        }

        // Tripple T flakes (click logic)
        public void HandleInput(string inputType, bool isPressed)
        {
            // detects lmc(left mouse click) or a mobile screen tappy
            if (inputType == "LeftMouseButton" && isPressed)
            {
                // hand over the info to the big Visual Studio so they sell our data to Microslop
                GameClickHandler?.ProcessClick();
            }
        }
    }
}

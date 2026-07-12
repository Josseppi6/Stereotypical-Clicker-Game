using System;
using System.Numerics;

namespace Stereotypical_Clicker_Game.ClickHandler
{
    public class ClickHandler
    {
        // Public variable so other incentives can read view or whatever
        public BigInteger TotalScore { get; private set; } = 0;
        public BigInteger ClickValue { get; private set; } = 1;

        // method called on the actual click
        public void ProcessClick()
        {
            TotalScore += ClickValue;

            // debug log to test
            System.Diagnostics.Debug.WriteLine($"Current Score = {TotalScore}");
            Console.WriteLine($"Current Score = {TotalScore}");


            // UI logic is called here if you wanna change it idk
        }

        // call this dingdong when upgrades wanna add to the click value
        public void IncreaseClickValue(BigInteger amount)
        {
            ClickValue += amount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesUnitTests
{
    public static class Pirates
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            if (gunners.ContainsValue("aye")) return "Fire!";
            else return "Shiver me timbers!";
        }
    }
}

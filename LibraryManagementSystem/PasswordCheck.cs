using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum PasswordScore
    {
        Blank = 0,
        TooShort = 1,
        RequirementsNotMet = 2,
        VeryWeak = 3,
        Weak = 4,
        Fair = 5,
        Medium = 6,
        Strong = 7,
        VeryStrong = 8
    }
    public static class PasswordCheck
    {
        public static PasswordScore CheckStrength(string password)
        {
            int score = 0;


            bool blnMinLengthRequirementMet = false;
            bool blnRequirement1Met = false;
            bool blnRequirement2Met = false;


            if (password.Length < 1)
            {
                return PasswordScore.Blank;
            }


            if (password.Length < 6)
            {
                return PasswordScore.TooShort;
            }
            else
            {
                score++;
                blnMinLengthRequirementMet = true;
            }

            if (password.Length >= 8)
            {
                score++;
            }

            if (password.Length >= 10)
            {
                score++;
            }

            if (Regex.IsMatch(password, @"[\d]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement1Met = true;
            }

            if (Regex.IsMatch(password, @"[a-z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            if (Regex.IsMatch(password, @"[A-Z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            if (Regex.IsMatch(password, @"[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript))
                score++;

            List<char> lstPass = password.ToList();
            if (lstPass.Count >= 3)
            {
                for (int i = 2; i < lstPass.Count; i++)
                {
                    char charCurrent = lstPass[i];
                    if (charCurrent == lstPass[i - 1] && charCurrent == lstPass[i - 2] && score >= 4)
                    {
                        score++;
                    }
                }
            }

            if (!blnMinLengthRequirementMet || !blnRequirement1Met || !blnRequirement2Met)
            {
                return PasswordScore.RequirementsNotMet;
            }

            return (PasswordScore)score;
        }
    }
}


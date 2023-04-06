using System;
namespace LumaAutomatedWebTestingProject.Utils
{
    public class RandomEmail
    {
        public string GenerateRandomEmail(Random random)
        {
            string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";
            string email = "";
            int usernameLength = 12;

            for (int index = 0; index < usernameLength; index++)
            {
                int randomLetterIndex = random.Next(26);
                email += lowerLetters[randomLetterIndex];
            }
            email += "@example.com";
            return email;
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.service.seguranca
{
    public class PasswordManager
    {
        HashComputer m_hashComputer = new HashComputer();

        public string GeneratePasswordHash(string plainTextPassword, out string salt)
        {
            SaltGenerator saltGenerator = new SaltGenerator();
            salt = saltGenerator.GetSaltString();

            string finalString = plainTextPassword + salt;

            return m_hashComputer.GetPasswordHashAndSalt(finalString);
        }

        public bool IsPasswordMatch(string password, string salt, string hash)
        {
            string finalString = password + salt;
            return hash == m_hashComputer.GetPasswordHashAndSalt(finalString);
        }
    }
}

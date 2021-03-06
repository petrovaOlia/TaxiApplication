﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DClient
{
    static class Program
    {
        public static Guid userID;
        public static FormRegistrate formRegistrate;
        public static FormEnter formEnter;
        public static FormMain formMain;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formRegistrate = new FormRegistrate();
            formEnter = new FormEnter();
            formMain = new FormMain();

            Application.Run(formEnter);
        }
    }
}

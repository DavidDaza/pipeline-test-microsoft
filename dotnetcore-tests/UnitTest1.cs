using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_sample;
using NUnit.Framework;
using dotnetcore;

namespace dotnetcore_tests
{
    [TestFixture]
    public class LoginTestCls
    {
        [TestCase]
        public void Autenticacion_de_usuario_correcta()
        {
            var login = new LoginCls();

            NUnit.Framework.Assert.AreEqual("Autenticacion de usuario correcta.", login.autenticacionDeUsuarios("uswe", "Pass1258/*"));

        }

    }
}

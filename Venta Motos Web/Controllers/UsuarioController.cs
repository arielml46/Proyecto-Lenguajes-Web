using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venta_Motos_Web.Models;
//Para obtener la clase crypto para realizar el encriptamiento de la contraseña
using System.Web.Helpers;
//Contiene las clases q se utilizan para implementar la seguridad de los servicios
//en la validacion de los datos
using System.Web.Security;

namespace Venta_Motos_Web.Controllers
{
    public class UsuarioController : Controller
    {

        [HttpGet]
        public ActionResult Logeo()
        {
            return View();
        }
        /// <summary>
        /// Verificar los datos suministrados 
        /// por el usuario al realizar la peticion Post
        /// </summary>
        /// <param name="user"></param>
        /// <param name="retornarUrl"></param>
        /// <returns></returns>
        
        [HttpPost]
        public ActionResult Logeo(Models.LogeoModel user, string retornarUrl)
        {
            //Verifica el modelo de datos que se utiliza
            if (ModelState.IsValid)
            {
                //Envia al metodo para validar el acceso
                if (ValidarUsuarios(user.usu_nombre, user.usu_password))
                {
                    FormsAuthentication.SetAuthCookie(user.usu_nombre, user.RememberMe);
                    if (Url.IsLocalUrl(retornarUrl) && retornarUrl.Length > 1 && retornarUrl.StartsWith("/")
                        && !retornarUrl.StartsWith("//") && !retornarUrl.StartsWith("/\\"))
                    {
                        return Redirect(retornarUrl);
                    }//fin del if(Url)
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "El nombre o la contraseña especificada son incorrectos");
                }// fin del if de ValidarUsuarios
            }
            return View();
        }// fin del metodo HttpPost de Logeo

        /// <summary>
        /// Metodo para validar el correo y la contraseña del usuario
        /// </summary>
        /// <param name="pNombre"> correo electrónico ingresado</param>
        /// <param name="pPassword">contraseña ingresada</param>
        /// <returns>
        /// true= usuario valido
        /// false=usuario invalido
        /// </returns>
        private bool ValidarUsuarios(string pNombre, string pPassword)
        {
            bool retorno = false;
            string encriptado;
            using (var db = new DB_Ventas_AutomovilesContext())
            {
                var user = db.Tbl_Usuarios.FirstOrDefault(u => u.usu_nombre == pNombre);
                if (user != null)//verifica que exista
                {
                    encriptado = user.usu_password;
                    if (pPassword == encriptado)
                    {
                        retorno = true;
                    }
                }
            }//fin del using db
            return retorno;
        }//fin del metodoValidarUsuarios
        
        /// <summary>
        /// Metodo para cerrar la sesion de usuario
        /// </summary>
        /// <returns></returns>
        public ActionResult Salida()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }//fin del metodo Salida
    
    }
}

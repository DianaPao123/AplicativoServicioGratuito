using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using ServicioLocalContract;

namespace ServicioLocal.Business
{
    public class NtLinkLogin : NtLinkBusiness
    {
        public static MembershipUser ValidateUser(string userName, string pass)
        {
            try
            {
                if (Membership.ValidateUser(userName, pass))
                    return Membership.GetUser(userName);
                else
                {
                    Logger.Info("Usuario Inválido, " + userName);
                    return null;
                }
            }
            catch (Exception ee)
            {
                Logger.Error(ee.Message);
                return null;
            }
            
        }


        public static UsuariosPruebas ValidateUserPruebas(string userName, string pass)
        {
            try
            {
                using (var db = new NtLinkLocalServiceEntities())
                {
                    var confirma = db.UsuariosPruebas.Where(p => p.Usuario == userName && p.Contraseña == pass && p.Activo == true).FirstOrDefault();
                    if (confirma != null)
                        return confirma;
                    else
                    {
                        Logger.Info("Usuario Inválido, " + userName);

                        return null;
                    }
                }
            }
            catch (Exception ee)
            {
                Logger.Error(ee.Message);
                return null;
            }

        }
        public static UsuariosPruebas ValidateUserPruebas(int id)
        {
            try
            {
                using (var db = new NtLinkLocalServiceEntities())
                {
                    var confirma = db.UsuariosPruebas.Where(p => p.ID == id).FirstOrDefault();
                    if (confirma != null)
                        return confirma;
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ee)
            {
                Logger.Error(ee.Message);
                return null;
            }

        }

    }
}

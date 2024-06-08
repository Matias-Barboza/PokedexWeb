﻿using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public static class Seguridad
    {
        public static bool SessionActiva(object user)
        {
            Trainee trainee = user != null ? (Trainee)user : null;

            return trainee != null && trainee.Id != 0;
        }

        public static bool EsAdmin(object user) 
        {
            Trainee trainee = user != null ? (Trainee) user : null;

            return trainee != null? trainee.Admin : false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormForRegisterDB
{
    public class Class1
    {

        int HoldAccess;

        int UserAccessLevel(int inputAccessLevel)
        {
            int access = inputAccessLevel;
            HoldAccess = access;

            return HoldAccess;
        }
    }
}
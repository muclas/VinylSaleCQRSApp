using System;
using System.Collections.Generic;
using System.Text;

namespace Commands.WebShop
{
    public class CartAlreadyOpen : Exception
    {
    }

    public class CartNotOpen : Exception
    {
    }

    public class ItemNotInCart : Exception
    {
    }
}

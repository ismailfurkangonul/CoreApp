using System.Collections.Generic;

namespace CoreApp.Models
{
    public static class CustomerContext
    {
        public static List<Customer> customers = new()
        {
            new Customer{Name="Dries",SurName="Mertens"},



        };
    }
}

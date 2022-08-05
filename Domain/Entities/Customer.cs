using System.Security.AccessControl;
using Domain.Common;

namespace Domain.Entities;

public class Customer : AuditableBaseEntity
{
    private int _age;
    
    public string Name { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public int Age
    {
        get
        {
            if (this._age <= 0)
            {
                this._age = new DateTime(DateTime.Now.Subtract(this.BirthDate).Ticks).Year - 1;
            }

            return this._age;
        }
    }
}
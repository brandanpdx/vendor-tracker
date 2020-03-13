using System.Collections.Generic;

namespace VendorTracker.Models 
{
  public class VendorTracker
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDesc { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public VendorTracker(string vendorName, string vendorDesc)
    {
      VendorName = vendorName;
      VendorDesc = vendorDesc;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }


  }
}

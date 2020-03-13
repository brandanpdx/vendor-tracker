using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDesc { get; set; }
    public string OrderPrice {get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDesc, string orderPrice, string orderDate)
    {
      OrderTitle = orderTitle;
      OrderDesc = orderDesc;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}
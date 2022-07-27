using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace csharp
{
  [TestFixture]
  public class GildedRoseTest
  {
    [Test]
    public void Should_QualityIsNotNegative_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "foo", SellIn = 0, Quality = 0 } ,
              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
              new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15,Quality = 20},
              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 15,Quality = 20},
              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
    };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }

      Assert.AreNotEqual(-1, Items[0].Quality);
      Assert.AreNotEqual(-1, Items[1].Quality);
      Assert.AreNotEqual(-1, Items[2].Quality);
      Assert.AreNotEqual(-1, Items[3].Quality);
      Assert.AreNotEqual(-1, Items[4].Quality);
      Assert.AreNotEqual(-1, Items[5].Quality);
      Assert.AreNotEqual(-1, Items[6].Quality);
    }

    [Test]
    public void Should_SellIn_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "foo", SellIn = 0, Quality = 0 } ,
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreNotEqual(-1, Items[0].Quality);
    }

    [Test]
    public void Should_SellIn_IsNegative_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "foo", SellIn = -1, Quality = 10 } ,
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreNotEqual(-1, Items[0].SellIn);
    }


    [Test]
    public void Should_NormalGoods_AreUpdated_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
    }

    [Test]
    public void Should_AgedBrie_AreUpdated_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "Aged Brie", SellIn = 10, Quality = 20},
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreEqual("Aged Brie", Items[0].Name);
    }

    [Test]
    public void Should_Backstage_AreUpdated_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20},
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
    }

    [Test]
    public void Should_Conjured_AreUpdated_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "Conjured Mana Cake", SellIn = 10, Quality = 20},
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
    }

    [Test]
    public void Should_Sulfuras_AreUpdated_When_UpdateQuality_IsCalled()
    {
      IList<Item> Items = new List<Item> {
              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20},
            };
      GildedRose app = new GildedRose(Items);
      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- day " + i + " --------");
        Console.WriteLine("name, sellIn, quality");
        for (var j = 0; j < Items.Count; j++)
        {
          Console.WriteLine(Items[j]);
        }
        Console.WriteLine("");
        app.UpdateQuality();
      }
      Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
    }

    

  }
}

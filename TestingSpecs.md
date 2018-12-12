# Testing specs for child objects
<sup>_Chris Rudnicky_</sup>

## Table of Contents:
- [Get Parent Object]("#GetCategories") <sub>GetCategories()</sub>

---

## `GetCategories()`
###### In this example the category is the parent object. Naming conventions will differ based on the project.  
- Written as:
>`public List<category> GetCategories() { }`  

This method is used to retrieve a list of **parent objects**  we can insert this test into the child object class to associate child objects with parent objects, or we could use it to display a information about parent objects if it is used in the parent object class.

Inside the test file write the following method. Be sure change any mention of a category to whatever the parent object in your current project is.

      [TestMethod]
      public void GetCategories_ReturnsAllItemCategories_CategoryList()
      {
        Item testItem = new Item("Mow the lawn");
        testItem.Save();
        Category testCategory1 = new Category("Home stuff");
        testCategory1.Save();
        Category testCategory2 = new Category("Work stuff");
        testCategory2.Save();
        testItem.AddCategory(testCategory1);
        List<Category> result = testItem.GetCategories();
        List<Category> testList = new List<Category> {testCategory1};
        CollectionAssert.AreEqual(testList, result);
      }


To fail this test we will write this code:

```

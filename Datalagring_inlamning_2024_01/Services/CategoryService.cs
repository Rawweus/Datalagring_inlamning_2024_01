using Datalagring_inlamning_2024_01.Entities;
using Datalagring_inlamning_2024_01.Repositories;

namespace Datalagring_inlamning_2024_01.Services;

public class CategoryService(CategoryRepository categoryRepository)
{
    private readonly CategoryRepository _categoryRepository = categoryRepository;

    public void AddCategory(CategoryEntity category)
    {
        _categoryRepository.Add(category);
    }


    public void RunMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till kategori");
            Console.WriteLine("2. Visa kategorier");
            Console.WriteLine("3. Ändra befintlig kategori");
            Console.WriteLine("4. Ta bort en kategori");
            Console.WriteLine("5. Avsluta");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCategoryFromConsole();
                    break;
                case "2":
                    DisplayCategories();
                    break;
                case "3":
                    UpdateCategoryFromConsole();
                    break;
                case "4":
                    DeleteCategoryFromConsole();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void AddCategoryFromConsole()
    {
        Console.Write("Ange kategorinamn: ");
        var name = Console.ReadLine()!;
        var newCategory = new CategoryEntity { Name = name };
        _categoryRepository.Add(newCategory);
        Console.WriteLine("Kategori tillagd.");
        Console.ReadKey();
    }

    private void DisplayCategories()
    {
        var categories = _categoryRepository.GetAll();
        foreach (var category in categories)
        {
            Console.WriteLine($"ID: {category.CategoryId}, Namn: {category.Name}");
        }
        Console.ReadKey();
    }

    private void UpdateCategoryFromConsole()
    {
        Console.Write("Ange ID för kategorin du vill uppdatera: ");
        int id = int.Parse(Console.ReadLine()!);
        var category = _categoryRepository.Get(id);
        if (category == null)
        {
            Console.WriteLine("Kategori hittades inte.");
        }
        else
        {
            Console.Write("Ange det nya namnet på kategorin: ");
            category.Name = Console.ReadLine()!;
            _categoryRepository.Update(category);
            Console.WriteLine("Kategori uppdaterad.");
        }
        Console.ReadKey();
    }

    private void DeleteCategoryFromConsole()
    {
        Console.Write("Ange ID för kategorin du vill ta bort: ");
        int id = int.Parse(Console.ReadLine()!);
        var category = _categoryRepository.Get(id);
        if (category == null)
        {
            Console.WriteLine("Kategori hittades inte.");
        }
        else
        {
            _categoryRepository.Delete(category);
            Console.WriteLine("Kategori borttagen.");
        }
        Console.ReadKey();
    }


    public IEnumerable<CategoryEntity> GetAllCategories()
    {
        return _categoryRepository.GetAll();
    }

    public CategoryEntity GetCategoryById(int id)
    {
        return _categoryRepository.Get(id);
    }

    public void UpdateCategory(CategoryEntity category)
    {
        // Här kan du lägga till validering eller ytterligare logik om så behövs
        _categoryRepository.Update(category);
    }

    public void DeleteCategory(CategoryEntity category)
    {
        _categoryRepository.Delete(category);
    }
}

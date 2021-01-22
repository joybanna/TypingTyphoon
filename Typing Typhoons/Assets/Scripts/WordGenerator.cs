using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class WordGenerator : MonoBehaviour
{
    #region wordlist
    private static string[] wordListEasy =  
    {
        "bacon", "bagel", "beef", "beet","berry","bread","buns","cake","candy","cheese"
        ,"chicken","chili","chips","crispy","curry","dip","egg","grape","ham","honey",
        "jam","jelly","juice","kebab","kiwi","laksa","lox","mangu","milk","mochi",
        "nut","onion","pie","pizza","plum","pork","ramen","rice","roti","salad",
        "satay","soup","steak","sushi","syrup","tacos","tart","tofu","wafer","waffle","acorn",
        "aspic","bakery","barley","basil","batter","beans","bitter","tea","pea","bran",
        "caviar","celery","cereal","chard","cherry","chives","citrus","clam","clove","cod",
        "corn","crust","curds","daikon","pastry","dates","dill","dough","durian","fig",
        "garlic","gyro","nutmeg","olive","oyster","pate","pickle","pilaf","pita","salami",
        "stew","yogurt","soy"
    }; 
    private static string[] wordListNormal = 
    {
        "almond","anchovy","apricot","avocado","beancurd","biscuits","Borscht","brisket","brownie","Bulgogi",
        "burrito","butter","caramel","carrot","cashew","cassava","Changua","cheddar","chutney","cilantro",
        "cobbler","coconut","coffee","collard","cookie","cornmeal","crackers","crumble","cucumber","cupcake",
        "currants","custard","doughnut","fajitas","gelatin","gulasch","hamburger","hummus","ketchup","Kimchi",
        "lasagna","lettuce","lobster","lychee","meatball","meatloaf","mussels","noodles","oatmeal","onion",
        "orange","paella","pancakes","pepper","poutine","pudding","radish","ricotta","sandwich","sashimi",
        "sausage","shallots","sorbet","stamppot","tamale","trifle","turkey","waakye","walnut",
     };
    private static string[] wordListHard = 
    {
        "appetizer","artichoke","asparagus","barbecue","bibimbap",
        "blueberry","boysenberry","breadfruit","broccoli","buckwheat",
        "casserole","cauliflower","ceviche","cheeseburger","cheesecake",
        "chocolate","cinnamon","coleslaw","cornflakes","cranberry",
        "croissant","currywurst","dragonfruit","eggplant","guacamole",
        "hafragrautur","jajecznica","longganisa","macaroni","macaroon",
        "marshmallow","mozzarella","mushroom","okonomiyaki","saltenas",
        "spaghetti","sprinkles"
    };

    private static List<string> EW;
    private static List<string> NW;
    private static List<string> HW;
    #endregion
    const string wordF = "FoodList.csv";
    public static int index;
    public static string randomword;
    public static float timeCD;
    public static float Maxtime;
    public static string GetRandomWord(int easy, int normal, int hard)
    {
        #region Condition to Mode
        if (easy == 1 && normal == 0 && hard == 0)
        {
            timeCD = 10.5f;
            Maxtime = 10.5f;
            int randomIndex = Random.Range(0, wordListEasy.Length);
            index = randomIndex;
            randomword = wordListEasy[randomIndex];
            return randomword;
        }
        else if (easy == 0 && normal == 1 && hard == 0)
        {
            timeCD = 12.5f;
            Maxtime = 12.5f;
            int randomIndex = Random.Range(0, wordListNormal.Length);
            index = randomIndex;
            randomword = wordListNormal[randomIndex];
            return randomword;
        }
        else if (easy == 0 && normal == 0 && hard == 1)
        {
            timeCD = 15.5f;
            Maxtime = 15.5f;
            int randomIndex = Random.Range(0, wordListHard.Length);
            index = randomIndex;
            randomword = wordListHard[randomIndex];
            return randomword;
        }
        else if (easy == 1 && normal == 1 && hard == 0)
        {
            //print("E&N");
            int mode = Random.Range(1, 3);
            print(mode);
            if (mode == 1)
            {
                timeCD = 10.5f;
                Maxtime = 10.5f;
                int randomIndex = Random.Range(0, wordListEasy.Length);
                index = randomIndex;
                randomword = wordListEasy[randomIndex];
                return randomword;
            }
            else if (mode >= 2)
            {
                timeCD = 12.5f;
                Maxtime = 12.5f;
                int randomIndex = Random.Range(0, wordListNormal.Length);
                index = randomIndex;
                randomword = wordListNormal[randomIndex];
                return randomword;
            }
            return randomword;
        }
        else if (easy == 0 && normal == 1 && hard == 1)
        {
            //print("N&H");
            int mode = Random.Range(1, 3);
            print(mode);
            if (mode == 1)
            {
                timeCD = 12.5f;
                Maxtime = 12.5f;
                int randomIndex = Random.Range(0, wordListNormal.Length);
                index = randomIndex;
                randomword = wordListNormal[randomIndex];
                return randomword;
            }
            else if (mode >= 2)
            {
                timeCD = 15.5f;
                Maxtime = 15.5f;
                int randomIndex = Random.Range(0, wordListHard.Length);
                index = randomIndex;
                randomword = wordListHard[randomIndex];
                return randomword;
            }
            return randomword;
        }
        else if (easy == 1 && normal == 1 && hard == 1)
        {
            //print("E&N&H");
            int mode = Random.Range(1, 5);
            //print(mode);
            if (mode == 1)
            {
                timeCD = 10.5f;
                Maxtime = 10.5f;
                int randomIndex = Random.Range(0, wordListEasy.Length);
                index = randomIndex;
                randomword = wordListEasy[randomIndex];
                return randomword;
            }
            else if (mode == 2)
            {
                timeCD = 12.5f;
                Maxtime = 12.5f;
                int randomIndex = Random.Range(0, wordListNormal.Length);
                index = randomIndex;
                randomword = wordListNormal[randomIndex];
                return randomword;
            }
            else if (mode >= 3)
            {
                timeCD = 15.5f;
                Maxtime = 15.5f;
                int randomIndex = Random.Range(0, wordListHard.Length);
                index = randomIndex;
                randomword = wordListHard[randomIndex];
                return randomword;
            }
            return randomword;

        }
        #endregion
        return randomword;
    }
    #region inputWord
    private void Awake()
    {
        //print("input");
        //InputWord();
    }
    public void InputWord()
    {
        StreamReader input = null;
        input = File.OpenText(Path.Combine(Application.streamingAssetsPath, wordF));

        string nameHead = input.ReadLine();
        print(nameHead);
        string wordlist = input.ReadLine();
        while (wordlist != null)
        {
            print("reading");
            GetData(wordlist);
            wordlist = input.ReadLine();
        }
        if (wordlist == null)
        {
            print("readEnd");
            wordListEasy = EW.ToArray();
            wordListNormal = NW.ToArray();
            wordListHard = HW.ToArray();

        }

    }
    public void GetData(string dataword)
    {
        print("getdata");
        string[] values = dataword.Split(',');
        if (dataword != null)
        {
            EW.Add(values[0]);
            NW.Add(values[1]);
            HW.Add(values[2]);
        }
    }
    #endregion
   
}


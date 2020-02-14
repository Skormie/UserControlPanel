using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserControlPanel.Models;

namespace UserControlPanel.DAL
{
    public class CPInitializer : System.Data.Entity.DropCreateDatabaseAlways<CPContext>
    {
        protected override void Seed(CPContext context)
        {
            context.Login.Add(new Login
            {
                ID = 0,
                Username = "user1",
                Password = "superpassword",
                LastLogin = DateTime.Now,
                AccountCreationDate = DateTime.Now
            });
            context.Login.Add(new Login
            {
                ID = 1,
                Username = "user2",
                Password = "admin",
                LastLogin = DateTime.Now,
                AccountCreationDate = DateTime.Now
            });
            context.Login.Add(new Login
            {
                ID = 2,
                Username = "user3",
                Password = "pass",
                LastLogin = DateTime.Now,
                AccountCreationDate = DateTime.Now
            });

            context.Character.Add(new Character
            {
                LoginID = 0,
                ID = 0,
                Name = "Light4Life",
                Level = 3,
                Class = Job.ACOLYTE,
                Experience = 5,
                Next = 10,
                CharacterCreationDate = DateTime.Now
            });

            context.Character.Add(new Character
            {
                LoginID = 0,
                ID = 1,
                Name = "OnChotOneKill",
                Level = 5,
                Class = Job.SNIPER,
                Experience = 5,
                Next = 50,
                CharacterCreationDate = DateTime.Now
            });

            context.Character.Add(new Character
            {
                LoginID = 1,
                ID = 0,
                Name = "Numbers",
                Level = 10,
                Class = Job.ASSASSIN,
                Experience = 50,
                Next = 100,
                CharacterCreationDate = DateTime.Now
            });

            context.Character.Add(new Character
            {
                LoginID = 2,
                ID = 0,
                Name = "Kek",
                Level = 50,
                Class = Job.CHAMPION,
                Experience = 10,
                Next = 1000,
                CharacterCreationDate = DateTime.Now
            });

            context.Item.Add(new Item
            {
                ID = 0,
                Name = "Sword",
                Description = "Basic sword it does little to nothing.",
                Image = @"iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAMAAACdt4HsAAAAYFBMVEVHcEwPDw8VFRX///8ZGBcoKCgRDw4UFBQNDQ0TExPZ2dn8/PwcGxoiIiIREBCpqalBXWalpaWsrKz4+PjV1dXxjDf/5Tf2jzc/W2P44TZJX2PxkTf3kzfy8vLsijbQ0NDvtSJfAAAACnRSTlMAEP//9/wm+hQM9FwfqAAAAhdJREFUWMPdl+uOgjAQhQ0UKWVsgaLibX3/t9wzUERJVtti3M3OPwj90pmeOR1WyRS5XEXE3wAQ0QaRraWUMQC6Xq+ttfaS5XkeB2hbVaap3eAhEqAWATZYr8qytBkKIUPrwACL1WAo1MGiDKIIBqQpAK1KERrHGQdAHlEAbDm7YOtqqEMJUQhZFP4M1GyN4mVDGkMxBeoQUkmZ39JoW2RRUqCs7wBqKWDYQaJ1cGPJXOsEakzbSdbBu6A3AVQcgI9ulDQDslB/gHakIErKqS+C/aFAGprlrCL94Q4Q5w8F6pDbqS/C/YE/ZnP95/5QuPDyh6ZpzNwf8iGe+sWtOxtj6nl7+1yD7wOYuq7n/qARPhfxzR/AMKMqERq1bckL4Nq7NqZ5AMAwPgMY/cHgLK3rC8wRCdZfvWz/zh8sTqOBuC5c1JCLZ2zv0gxp8LGaEGkvB4z+0Lg6IIM6qL1Hf7hwHdAXXMW4AcTJmmJHoMUAToGPkAFFyOwwTnEQU835d1VVxXgk1W77WF/FeOQyALf/AwDeEKRE7n9nKAU8QjPEd7ofAFP79s+fB9z1f98bWN9R/4tB4tX8wAD+8tb/LCJ+1XXd8Wu7/RIv5ocekMyOjV9AUMftfr99Je0fAZUvQLhrbAagI+J0Pp9eNpd0MVcm8j/tdrtDbHcStn/+PQDXhFM4IETMbyLPD4LIS0jPrr34X+W3A74BDhE2TnZAiswAAAAASUVORK5CYII="
            });

            context.Item.Add(new Item
            {
                ID = 1,
                Name = "Potion",
                Description = "Simple HP potion restores small amount of HP.",
                Image = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAC1SURBVDhPY6A5sHMJ/g9lYgVMUBorAGnm5hGC8rADvAaANH/98g7KIwMQcj4IMEJpDIDsfJArDu1Zi1UtTi/48t1lsPiwD4xBbFwAq6nYAg+XK7C6wPnPBYZdbqYMDyuzwBjEBolhA1gN4BLiZVA3NmXw0lADYxAbJIYN4AwDkMZuPi6GaB4uMBsXwJsOLvxjYDDAqwKHAd/efWbYduMWw9Iv3xhKP30Ds0Fi2ADFsTDQgIEBACx7RFMoIeiaAAAAAElFTkSuQmCC"
            });
            
            context.Item.Add(new Item
            {
                ID = 2,
                Name = "Big Sheild",
                Description = "A powerful sheild.",
                Image = @"iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABGdBTUEAALGPC/xhBQAAAAFzUkdCAK7OHOkAAATFSURBVFjDtVchcOs6ECwMDDQ0FBQUFBQUFDQUFBQUNDQUNDQ0NDQMDAwMLHyw7N7syu28+eBPndeXGU2a1Pbt7e3tXd7eXnx520uwvej+ypMHLfju7V++glWiVS/BG3nuUfbqxJle8mDk1z1LzVasaoBw7V8HREaXyxsfFJyS561KSU6mbOWxDQQQXC+1WLkvgQAG1/N7HKuvX/d7050HtM2DlGiZ0TJ5Zl2zluiVLKPjsbrjZwQck+UBmG2yEkwnqr/KlI3MxfA53w7egjpZ5yC1ZglOyzpZuS1BotcylSDL6GXMXgA0DYZgcA2AgT1nlYxJSwpaSlQS3DdZ6LsD9eikJC11GmQqifUuycoyj5Kjl5w832PQkqMRbxVB4D0Ontfifgi0JMXyfIsFozoZfC/zZFumNci+JgYCiCE4KeMk636XddslxihadRK8EmuUlDyQvSk1YHUEC5101+v3y+BsL2MxMhUndfJfByAQ9OPjQ57Ph9zv7SDjGKys8yBjsTxgsUTNMoCZ6+XyfQ2gptPYNIBSLHMgpSlnBr+/P3n2+0PWdZNlnhkEIi0HAGokaQIx6nquC8BALU7mKRDI41aljlFKneT58c7g822VeZllWVaZ1pH0Q5CkPGoC/8xedZdzAAYIC201BlnmQT6es4zFS6qj7M8n6w8Rot513VgCbw2B7jPKFgTPGCDAqM+1IF7Ith7UzzXI8z7xoT5GAgAToJjX1ZkBoIFfjyIlG3YONJSSIpMvAGjiG8fGBDoBLKC3ASKXwExL9qQeCn/sRZbJsBt4QicLrola+jMlMLqXbRl40OfbkmSdrTxuWdbqWE9Qv1VYr+LnuUaaFPod4NNgJUUj++JpSt317fsAkBEGDAT4/qgEAjbmauW2Z2a6I9t1kH0Z2HrbEii8nAxte4eDFse2hR131xMMeKeYAcwH2aCWy+JI5+O+cSjtCL4XBoY+puM61B9jeozNuj0naCf9GQDW9PR2qh5GkjWpR1Awgjbb10me98p+39dIILBdnMGr5ph4B4D+BQ/AkMkpyJgdKQWAbYUerBSM44MFgMT/advZ0H5h45iK6AoMMdVfzgNA7z8fG4EwQG3tWIvhNAQTnA9ecx8AUACrWREAtLLCC5w6R//n8gHbhfoBYOREDASCpQPfNeENkkIbuZgZuAcLCsq31cAyQA999wqAaGWfIz0AbjYTgON0RP2RNeoOytHn+IzA2nRkY0qG6xk2oRcAaGbTABjxvvk62mrMgfWH493WwEUD9UZpcB8Uj4WkDIoAXmIAGwx8ADXEPE9HhhyvybE0AAAjwv9RErAA1cN0sH5BB/gbS8jpQRSO9gGNeDA2Gio8t4AwGQBoi4Y+FN/UD00gey4otj/fAZ/rNxjAQxob+lgsLEsDy+Uajo74WsdacLzjPmSOEpzugM8XAsLFMBcAYPwvgEehLtCG8TAef5gOgIRXxPfnC94NK+UiSSYUWwzlwXqOg/bjd7ZjYHUEp/Kvlx/4YWI61rMFbwoH5aAfP0zy0B+ZN7oBFqtX9xPB/9yQW6+3tRp/Y8RusyOwz14HC1D7jwb/80fKJxsTWjKjK7RE1/P7vxLbOTauzBR+D/rx+Z9l/X9s4EcnRdf9feDfZiYLNWkyIQYAAAAASUVORK5CYII="
            });

            //context.Inventory.Add(new Inventory
            //{
            //    CharacterID = 1,
            //    ItemID = 1,
            //    Quantity = 1
            //});

            //context.Inventory.Add(new Inventory
            //{
            //    CharacterID = 0,
            //    ItemID = 1,
            //    Quantity = 1
            //});

            //context.Inventory.Add(new Inventory
            //{
            //    CharacterID = 0,
            //    ItemID = 2,
            //    Quantity = 1
            //});

            //context.Inventory.Add(new Inventory
            //{
            //    CharacterID = 1,
            //    ItemID = 2,
            //    Quantity = 1
            //});

            context.SaveChanges();
        }
    }
}
# vedroid
Repository for Android labs

## AppName (in work)

### Idea
Our app is here to help those who can't choose the proper drink among wide variety of alcohol in stores. If you spend too much time in front of wine or beer shelfs, trying to choose better one, if you're not sure which kind of alcohol you should have for quiet evening with your girl or little party with your friends - we're here to help you with just a press of button!

### Possible users
Our average user is 18-35 y.o. person who is brave enough to try what we suggest and randomize his or her bottle of *something* for today. Currently we're aiming only for Kiev, but surely, the area will grow.

### Team

**Vladyslav Sobolevskiy** - developer

**Smuchok Darina** - UI\UX design

### Technologies and versions supported

* Xamarin - because our dev has experience with C#, and considers it as the most convenient variant for himself 
* Figma - it's one of the best variants, when it comes to creating interfaces and prototypes. Also, already worked with it.
* Miro - good variant for creating some very basic wireframes and mindmaps.
* Postgres - for DB, as we both have experience with it
* ASP.NET Core - backend

Any further technological desicions will be added and described during the development. 

We're going to support Android 9, 10.

### Prototype 

[prototype link](https://miro.com/app/board/o9J_lUcO4V8=/)

### Screens

Our app will have 3 main tabs:
* **Drink** - from this tab you can access a catalog of all drinks that we store in our database, sorted by categories. By choosing one particular item, you go to its page, with more information, including best matches with some snacks.
* **Snack** - from this tab you can access a catalog of all dishes and snacks that we store in our database, sorted by categories. By choosing one particular item, you go to its page, with more information, including best matches with some drinks.
* **Random** - for randomizing your beer for today

So, basically, for **Snack** and **Drink** tabs we have:
 * a catalog screen 
 * screen with list or table of products 
 * inividual screen for particular item

**Random** tab has only one screen for now, and supposed to redirect you to the page of individual drink (beer)



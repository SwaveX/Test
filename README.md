# Task 1 
## Class, Random, matrix, get / set, private / public, constructor
 
* Creatae a class containing N x N sized matrix: [ matrix ]()
  * Declare `private` int `properties`: N, A, B
  * Declare a parametrized `constructor` .ctor(int n, int a, int b)
    * Setup the corresponding properties
    * Call [FillMatrix( int a, int b )]()
  * Declare a `private` void `method` FillMatrix(int minValue, int maxValue), which fills the matrix with random values in the range (minValue <= element <= maxValue)
  * Declare a `public` void `method` ShowMatrix() to output the [ matrix ]() data
  * Declare a `public` int `method` which returns the **odd** elements **amount**
* Test the behavior in [ Main( ) ]() `method`
***

<br>

## ARM

 * ստեղծել Կլասս որը կպարունակի NxN չափերով մատրիցա
    * Կլասսում պահել private դաշտեր N, A և B, ամբողջ թվերի համար, և նրանց համար ապահովել {set get} մեթոդները կարճ գրելաձևով,
    * ստեղծել private FillMatrix անունեով մեթոդ, որը կլրացնի մատրիցայի արժեքները [A, B] միջակայքից պատական թվերով
    * ստեղծել public ShowMatrix մեթոդը, որը ցույց կարտածի մատրիցայի պարունակությունը
    * ստեղծել մեթոդ որը կվերադարձնի մատրիցայի կենտ թվերի քանակաը
    * պարամետրիզացված Կոնստրուկտորով տեղադրել N, A և B դաշտերի արժեքները որից հետո կանչել FillMatrix մեթոդը
    * ցույց տալ կլասսի ֆունկիոնալությունը Main() մեթոդում
***

<br><br>

# Task 2
## Method overloading, default parameters

* Declare `private` `static` overloaded `method` [ ToMultiplicate(< > x, int n = 2) ]() that returns _n times_ `x` regardless of type for `x`
  * Formal Parameter **x**: Types are `int`, `double`, `string`
  * Formal Parameter **n**: Default value is 2
* Test the behavior in [ Main( ) ]() `method`


## ARM

*Method overloading, default parameters,
    * Ստեղծել static ToMultiplicate մեթոդը, 3 օրինակով, որը կնդունի x, N փոփոխականները
    * N-ը կունենեա ըսկ լռելյայն (default) արժեք 2, կլինի int տիպի
    * իսկ x-ը կլինի երեք տարբերակով int, double և string
    * ֆունկցիան պիտի վերադարձնի N հատ x-երի գումարը, հատուկ սենց գրեցի որ string-ի դեպքն էլ հասկանալի լինի
    * թեստավորել overloading-ի աշխատանքը Main() մեթոդում
 ***

<br><br>

# Task 3
## String, Formatting, Enum, Switch

* Declare `class` [ Movie.cs ]() with following `public` `members`:

* ### Properties `properties`
  * `prop` `int` Id {get; set; }
  * `prop` `string` Title {get; set; }
  * `prop` `DateTime` ReleasedYear {get; set; }
  * `prop` `Genre` FilmGenre {get; set; }
    * `enum` `Genre`: 5 constants
  * `prop` `long` Views {get; set; }
  * `prop` `long` Likes {get; set; }

* ### Methods `methods`
  * `double` `method` [ GetRating( ) ]() => `Sqrt( Math.Pow(Likes, 2) / Views )` 
  * override `string` [ ToString( ) ]() when called:
    * Id { FontSize: 4, [ PadRight( ) ]()}
    * Title { FontSize: 15, [ Padleft( ) ]()}
    * ReleasedYear inside parenthesis { FontSize: 8, [ Padleft( ) ]()}
    * Genre { FontSize: 12, [ Padleft( ) ]()}
    * [ GetRating( ) ]() - precision: **3 decimal places** { FontSize: 8, [ Padleft( ) ]()}

 
* Test the behavior in [ Main( ) ]() `method`
   * Input the data via [ Console.ReadLine() ](), [ Split() ]()
   * Input the amount of Movies
     * For each Movie input corresponding data   
     * Input `Genre` via integer numbers

## ARM

* ստեղծել Movie.cs կլասսը որը կպարունակի [ֆիլմի համարը, ֆիլմի անունը, տարեթիվը, ֆիլմի ժանրը, դիտումների քանակը, լայքերի քանակը]
* ֆիլմի ժանրի համար ստեղծել enum 5 տարբերակ պարունակող, ըստ ձեր  հայեցողությամբ
* Մուրտքագրումը կատարել Console-ից ReadLine() մեթոդով, ժանրը գրել որպես 1 ից 5 թիվ, որից հետո ինֆորմացիան տարանջատել (split) և տեղավորել կլասսի դաշտերում.
* ստեղծել նաև մեթոդ որը կհաշվի ֆիլմի ռեյտինգը հետևյալ բանաձևով SQRT(Likes ^ 2 / Views) կլինի double տիպի;
* Movie.cs կլասսի համար override անել ToString() մեթոդը որը ցույց կտա կլասսի պարունակությունը հետևյալ կերպ
    - ֆիլմի համարը, {4 տառաչափ, կցել աջ}
    - ֆիլմի անունը, {15 տառաչափ, կցել ձախ}
    - տարեթիվը,    {8 տառաչափ, կցել ձախ և փակագծերի մեջ օր․"(2011)"}
    - ֆիլմի ժանրը,  {12 տառաչափ, տեքստային, կցել ձախ}
    - ռեյտինգը {8 տառաչափ, ստրոակետրից հետո 1000-րդական ճշտությամբ, անպայման ցույց տա նաև եթե զրոներ են}
* ցույց տալ կլասսի ֆունկիոնալությունը Main() մեթոդում, ծրագիրը սկզբում կընդհունի քանակը օրինակ 7 և հետո ցիկլով կնդունի 7 հատ ֆիլմի տվյալներ, այնուհետև ցիկլով ցույց կտա ֆորմատավորված տեսքով։  
* որպեսզի ավելորդ չբարդացնեք բոլոր մեմբերները և մեթոդները ստեղծել public


 ***
 
<br><br>

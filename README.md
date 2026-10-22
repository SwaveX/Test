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

* Declare `private` `static` overloaded `method` [ ToMultiplicate(int n = 2, < > x ) ]() that returns _n times_ `x` regardless of type for `x`
  * Formal Parameter **n**: Default value is 2
  * Formal Parameter **x**: `int`, `double`, `string`,
* Test the behavior in [ Main( ) ]() `method`


## ARM

*Method overloading, default parameters,
    * Ստեղծել static ToMultiplicate մեթոդը, 3 օրինակով, որը կնդունի x, N փոփոխականները
    * N-ը կունենեա ըսկ լռելյայն (default) արժեք 2, կլինի int տիպի
    * իսկ x-ը կլինի երեք տարբերակով int, double և string
    * ֆունկցիան պիտի վերադարձնի N հատ x-երի գումարը, հատուկ սենց գրեցի որ string-ի դեպքն էլ հասկանալի լինի
    * թեստավորել overloading-ի աշխատանքը Main() մեթոդում

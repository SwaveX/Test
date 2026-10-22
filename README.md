# Task 1
 
* Creatae a class containing N x N sized matrix: [ matrix ]()
  * Declare `private` int `properties`: N, A, B
  * Declare a parametrized `constructor` .ctor(int n, int a, int b)
    * Setup the corresponding properties
    * Call [FillMatrix( int a, int b )]()
  * Declare a `private` void `method` FillMatrix(int minValue, int maxValue), which fills the matrix with random values in the range (minValue <= element <= maxValue)
  * Declare a `public` void `method` ShowMatrix() to output the [ matrix ]() data
  * Declare a `public` int `method` which returns the **odd** elements **amount**
* Use the behavior in [ Main( ) ]() `method`

## ARM

 * ստեղծել Կլասս որը կպարունակի NxN չափերով մատրիցա
    * Կլասսում պահել private դաշտեր N, A և B, ամբողջ թվերի համար, և նրանց համար ապահովել {set get} մեթոդները կարճ գրելաձևով,
    * ստեղծել private FillMatrix անունեով մեթոդ, որը կլրացնի մատրիցայի արժեքները [A, B] միջակայքից պատական թվերով
    * ստեղծել public ShowMatrix մեթոդը, որը ցույց կարտածի մատրիցայի պարունակությունը
    * ստեղծել մեթոդ որը կվերադարձնի մատրիցայի կենտ թվերի քանակաը
    * պարամետրիզացված Կոնստրուկտորով տեղադրել N, A և B դաշտերի արժեքները որից հետո կանչել FillMatrix մեթոդը
    * ցույց տալ կլասսի ֆունկիոնալությունը Main() մեթոդում

IPtoFlag
========

Instructions for testing:
This is a practical test for a job application,

1) Because it is not a real aplication and it is intend to test my skills I only did the Europe Continent, so if you are going to test this aplication be in mind that only Europe is implemented and the other continents will not work (It's the same thing for the other continents though)

2) If you want to test adding new countries to europe you just have to add it to the DataBase table Countries following the ID list bellow.
<div id="map-europe">
 <ul class="europe">
  <li class="eu1"><a href="#albania">Albania</a></li>
  <li class="eu2"><a href="#andorra">Andorra</a></li>
  <li class="eu3"><a href="#austria">Austria</a></li>
  <li class="eu4"><a href="#belarus">Belarus</a></li>
  <li class="eu5"><a href="#belgium">Belgium</a></li>
  <li class="eu6"><a href="#bosnia-and-herzegovina">Bosnia and Herzegovina</a></li>
  <li class="eu7"><a href="#bulgaria">Bulgaria</a></li>
  <li class="eu8"><a href="#croatia">Croatia</a></li>
  <li class="eu9"><a href="#cyprus">Cyprus</a></li>
  <li class="eu10"><a href="#czech-republic">Czech Republic</a></li>
  <li class="eu11"><a href="#denmark">Denmark</a></li>
  <li class="eu12"><a href="#estonia">Estonia</a></li>
  <li class="eu13"><a href="#france">France</a></li>
  <li class="eu14"><a href="#finland">Finland</a></li>
  <li class="eu15"><a href="#georgia">Georgia</a></li>
  <li class="eu16"><a href="#germany">Germany</a></li>
  <li class="eu17"><a href="#greece">Greece</a></li>
  <li class="eu18"><a href="#hungary">Hungary</a></li>
  <li class="eu19"><a href="#iceland">Iceland</a></li>
  <li class="eu20"><a href="#ireland">Ireland</a></li>
  <li class="eu21"><a href="#san-marino">San_Marino</a></li>
  <li class="eu22"><a href="#italy">Italy</a></li>
  <li class="eu23"><a href="#kosovo">Kosovo</a></li>
  <li class="eu24"><a href="#latvia">Latvia</a></li>
  <li class="eu25"><a href="#liechtenstein">Liechtenstein</a></li>
  <li class="eu26"><a href="#lithuania">Lithuania</a></li>
  <li class="eu27"><a href="#luxembourg">Luxembourg</a></li>
  <li class="eu28"><a href="#macedonia">Macedonia</a></li>
  <li class="eu29"><a href="#malta">Malta</a></li>
  <li class="eu30"><a href="#moldova">Moldova</a></li>
  <li class="eu31"><a href="#monaco">Monaco</a></li>
  <li class="eu32"><a href="#montenegro">Montenegro</a></li>
  <li class="eu33"><a href="#netherlands">Netherlands</a></li>
  <li class="eu34"><a href="#norway">Norway</a></li>
  <li class="eu35"><a href="#poland">Poland</a></li>
  <li class="eu36"><a href="#portugal">Portugal</a></li>
  <li class="eu37"><a href="#romania">Romania</a></li>
  <li class="eu38"><a href="#russia">Russia</a></li>
  <li class="eu39"><a href="#serbia">Serbia</a></li>
  <li class="eu40"><a href="#slovakia">Slovakia</a></li>
  <li class="eu41"><a href="#slovenia">Slovenia</a></li>
  <li class="eu42"><a href="#spain">Spain</a></li>
  <li class="eu43"><a href="#sweden">Sweden</a></li>
  <li class="eu44"><a href="#switzerland">Switzerland</a></li>
  <li class="eu45"><a href="#turkey">Turkey</a></li>
  <li class="eu46"><a href="#ukraine">Ukraine</a></li>
  <li class="eu47"><a href="#united-kingdom">United_Kingdom</a></li>
<!-- remove this comment and UK list item (above) to activate countries of the United Kingdom
  <li class="eu48"><a href="#england">England</a></li>
  <li class="eu49"><a href="#isle-of-man">Isle_of_Man</a></li>
  <li class="eu50"><a href="#northern-ireland">Northern_Ireland</a></li>
  <li class="eu51"><a href="#scotland">Scotland</a></li>
  <li class="eu52"><a href="#wales">Wales</a></li>
-->
 </ul>
</div>

For example, looking at the list above we have <li class="eu38"><a href="#russia">Russia</a></li>
if you want to add russia to the europe countries you just have to add the following line to the database countries values:
IdCountry = 38, Name = Russia, IdContinent = 6 (Because 6 is europe ID);

3) If you test the aplication and ADD an information about a country as local it will get the IP 127.0.0.1 and automatic set your location as "-", but if you hard code an IP in the ../Controller/HomeController.cs file inside the Create method it will search for the IP location and set it right in the database.

4) You can either select an european country from the map or once the dropdown menu is show you can select it from the menu as well. 

5) Many info data were created during testing and programing and doesn't contain real data, these were just testing data and I didn't want to remove so the analiser could check my progress. 

6) Filtering is working by clicking the funnel icon on top right of each collumn. When trying to filter a string try to avoid the "equals to" options and use others like "begin with" or "contains"


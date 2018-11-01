 BDD project to test BBC sigin in page was build in Visual Studio 2015.

This project can run in Chrome browser , IE and firefox

To run in chrome , IE and firefox you will need to install 
ChromeDriver 2.40. It will run in chrome browser version 67 and 70
GeckoDriver 0.13. It will run in firefox version 56
InternetExplorerDriver version 3. It will run in the IE browser version 11

To run the project in your choosen browser you will need: 

-To configure the appSettings section in app config file  by uncommenting the browser you want to run it on and commenting the others like below:

<add key="Browser" value="Firefox"/> //uncomment
    <!--add key="Browser" value="IE"/--> /comment
-Also add annotation @Browser_Chrome or @Browser_IE or @Browser_Firefox to the scenario this will show as a trait in Test Exploree with your browser name, you can just run your test from there 

To run it on multiple Browser you will need : 
-To configure the appSettings section in app config file  by uncommenting the browsers like below:
<add key="Browser" value="Chrome"/> //uncomment
<add key="Browser" value="Firefox"/> //uncomment
<add key="Browser" value="IE"/> //uncomment

-Also add all of the annotation to your scenario like below:
@Browser_Chrome
@Browser_IE 
@Browser_Firefox 
 If you build your solution you will see that in Test Explorer the the name of the browser is attached to the scenario, you can run the test in parallel

The test also provide a report that you will see in the BBD project folder where it is stored on the computer












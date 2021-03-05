# stationservice
Mise en œuvre d’une application « station-service »
Ecrivez un programme mettant en œuvre les éléments suivants :
Une voiture se caractérise par une marque, un prix, une consommation et une capacité de réservoir.
Elle possède entre autres des méthodes permettant de rouler une certaine distance (en consommant
de l’essence) et de remettre du carburant.
Une personne se caractérise par un nom et un prénom. Elle peut posséder un compte bancaire et
une voiture. Pour simplifier, nous ne considérerons pas de personne possédant plusieurs voitures ou
plusieurs comptes bancaires. Tous les payements ci-dessous se font via des transferts bancaires.
Un concessionnaire vend des voitures, en encaissant évidemment le payement correspondant.
Une station-service vend du carburant, à un prix donné.
Les stations Finoil offrent une promotion spéciale : à chaque fois que quelqu’un y fait un plein, il a
une chance sur 100 que ce plein soit gratuit.
Les stations Taxecool offrent quant à elle une carte de fidélité : chaque litre acheté donne un point,
et le client ayant accumulé 100 points reçoit 1 euro.
Il est également possible de faire le plein dans d’autres stations, qui n’offrent pas de promotion.
Oui-Oui, qui possède 45000 euros, achète une voiture (de la marque que vous voulez) à Monsieur
LaPompe, au prix de 12500 euros. Cette voiture a un réservoir de 55 litres et consomme 5.3 litres aux
cent kilomètres. Oui-oui fait le plein dans la station Finoil BonneEssence, roule 653 kilomètres, puis
refait le plein dans la station Taxecool MiamAuto, avant de rouler à nouveau 254 kilomètres.
Combien d’argent et d’essence lui restent-t-il alors ? Combien de points Taxecool possède-t-il ?
Remarques :
- Plusieurs éléments de l’énoncé ont été volontairement laissés dans le flou : à vous de
prendre les décisions appropriées.
- Vous êtes libres d’ajouter aux différentes classes tous les éléments qui vous sembleraient
nécessaires.
- L’un des buts de l’exercice est de vous permettre de mettre en œuvre des mécanismes
d’héritage : au moins une des classes ci-dessus le permet.
- Attention aussi à gérer les cas non autorisés et les différentes exceptions. Il est souvent utile
qu’une méthode renvoie un booléen indiquant si une opération a réussi ou non.

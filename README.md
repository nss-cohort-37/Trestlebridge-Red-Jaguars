# Trestlebridge Farms

You and your friends have decided to connect with the earth again and abandon your reliance on technology and urban vices. You have built a business plan, presented it to a bank, and have secured $5 million to purchase an abandoned farm and produce high quality, responsibly grown and raised meat, seed, eggs, feathers and compost.

You have met with other growers and ranchers in the Middle Tennessee area and have decided to purchase the following starter stock. For each resource, you will find where it will be stored on the farm, what is produces when processed, and how much it produces.

#### Livestock

| Cows  | Pigs  | Chickens  | Ducks | Goats | Ostriches | Sheep |
|---|---|---|---|---|--|--|
|  Grazing Fields | Grazing Fields | Chicken House | Duck House | Grazing Fields | Grazing Fields | Grazing Fields |
| Meat | Meat | Egg / Feather / Meat | Egg / Feather | Compost | Egg / Meat | Meat |
| 18.25kg | 8.4kg | 7 / .5kg / 1.7kg | 6 / .75kg |  7.5kg | 3 / 2.6kg | 5kg |


#### Seed

| Sunflower | Wildflower | Sesame |
|--- |---|---|
| Plowed or Natural Field | Natural Field  | Plowed Field |
| Seed / Compost | Compost | Seed |
| 150 / 2.6kg | 3.3kg | 40 |

## Storage Facilities

Listed below are the capacities of each storage facility.

| Plowed Field | Natural Field | Grazing Field | Chicken House | Duck House |
|---|---|---|---|---|
| 250 plants | 145 plants | 50 grazers | 78 | 42 |


## Processing Equipment

Listed below is how many animals/plants can be processed by each kind of equipment.

| Meat Processor | Seed Harvester | Composter | Feather Harvester | Egg Gatherer |
|---|---|---|---|---|
| 22 animals | 110 plants | 400 plants | 18 birds | 55 eggs |

## Farm Animals and Raw Materials System (FARMS)

> _"We don't need no stinkin' JavaScript!"_
>  -- Jayden Michaels (a.k.a. RetroMan)

Fancy web applications are so 2017. Command line applications provide a much more hands-on, personal, bespoke, artisinal experience when managing a farm such as Trestlebridge. Therefore, even though you are casting off your digital personas to lead a life connected with the land, you still want to use your hard-earned skills as developers to make management of your farm as efficient as possible.

Here are the main features that the application must be able to perform.

### Main Menu

When the user first executes FARMS, they should be welcomed to the system and be presented with the following menu.

```sh
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+

1. Create Facility
2. Purchase Animals
3. Purchase Seeds
4. Processing Options (this is a stretch goal)

Choose a FARMS option.
> _
```

### Facility Creation Options Sub-Menu

If the user chooses option 1, then the following menu should be displayed

```sh
1. Grazing field
2. Plowed field
3. Natural field
4. Chicken house
5. Duck house

Choose what you want to create.
> _
```

When the user makes a choice, a new instance of that type of facility should be added to a `List<>` on your farm.

### Animal Purchase Menu

If the user chooses 2 from the main menu, then she should see the following menu, with the animals listed in alphabetical order.

```sh
1. Chicken
2. Cow
3. Duck
4. Goat
5. Ostrich
6. Pig
7. Sheep

Choose animals to purchase.
> _
```

When the user makes a choice, then immediately show another prompt asking for how many. If the user chose Ostrich, then she should see this.

```sh
How many Ostrich would you like to buy?
> _
```

When she enters in how many to buy, then display all of the locations in which the animals can be stored. The current number of animals should be displayed for each location.

```sh
1. Grazing Field (21 animals)
2. Grazing Field (4 animals)

Where would you like to place the animals?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Grazing Field (21 animals)
2. Grazing Field (4 animals)

Where would you like to place the animals?
> _
```

### Seed Purchase Menu

If the user chooses 3 from the main menu, then she should see the following menu, with the plants listed in alphabetical order.

```sh
1. Sesame
2. Sunflower
3. Wildflower

Choose seed to purchase.
> _
```

When the user makes a choice, then immediately show another prompt asking for how many. If the user chose Sunflower, then she should see this.

```sh
How many Sunflower would you like to plant?
> _
```

When she enters in how many to plant, then display all of the locations in which the plants can be planted. The current number of plants should be displayed for each location.

```sh
1. Plowed Field (40 plants)
2. Plowed Field (210 plants)
3. Natural Field (0 plants)

Where would you like to plant the Sunflowers?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Plowed Field (40 plants)
2. Plowed Field (210 plants)
3. Natural Field (0 plants)

Where would you like to plant the Sunflowers?
> _
```

## Stretch Goals

1. Display groups of things in each facility
    ```sh
    1. Grazing Field (12 pig, 5 cow, 1 sheep)

    or

    1. Natural Field (65 sunflower, 30 wildflower)
    2. Plowed Field (60 sesame, 20 sunflower)
    ```

## Processing Animals and Plants

👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽👇🏽

**This is a stretch goal. Please make sure that you have menu options 1, 2, and 3 working before you take on menu option 4.**

☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻☝🏻

### Processing Options

If the user choose 4 from the main menu, she should see the following options.

```sh
1. Seed Harvester
2. Meat Processor
3. Egg Gatherer
4. Composter
5. Feather Harvester

Choose equipment to use.
> _
```

When the user selects a piece of equipment, then present her with the current facilities that contain plants or animals that can be processed by that equipment.

For example, if she chose Meat Processor, the following should be presented.

```sh
1. Grazing Field
```

1. Choose which facility to be used
1. Begin processing
1. Then show only resources that can be used by that facility. Students

### Processing Amount Sub-Sub-Menu

1. Choose amount (adds that many items to a list of appropriate type)
1. Choose another? (if yes, choose resource and choose amount again)

Create new instance of corresponding procesing facility immediately after choice. Instance has `public List<T>` of appropriate type. Invoke `.Process()` method on that instance and pass in the

Compost bins (can process 200 pounds of raw material each)
6. Create egg storage warehouse (can process 40 eggs each)
7. Create a slaughterhouse (can process 10 animals of any type at a time)
8. Create feather drying house (can process 10 birds at a time)


### Processing Option

Slaughterhouse -> Any meat producing animal
Process(List<IMeat> animals)
* Ensure list count not greater than 10
* Console.WriteLine how many pounds of meat was produced per animal

Seed harvesting -> Any seed producing plant
Harvest (List<ISeed> plants)
* No more than 100 plants can be processed
 * Console.WriteLine how many seeds was produced per planet

### Class Definition Notes

Each plant class should have a property that decribes what final product after processing
```cs
public string seedType { get; } = "Sesame";
public int seedAmount { get; } = 15;
```


Each animal class should have a property that decribes what final product after processing
```cs
public string meatType { get; } = "Beef";
public int meatAmount { get; } = 50;
```

### Farm Class

`public class Farm` needs to have `List<>` of all facilities except for slaughterhouse (see above).


# Notes

Meat producing (cow, pig, chicken, sheep, goat, duck)
Fertilizer producing (cow, sheep, sunflower, wildflower)
Egg producing (chicken, ostrich, duck)
Feather producing (chicken, duck)
Seed producing (sunflower, sesame)

Process (IMeatProducer animal)
Process (List<IMeatProducer> animals)

CollectEggs (IEggProducer bird)
CollectEggs (List<IEggProducer> birds)

Defeather (IFeatherProducer bird)
Defeather (List<IFeatherProducer> birds)

Compost (IFertilizer resource)
Compost (List<IFertilizer> resources)

CollectSeed (ISeedProducer plant)
CollectSeed (List<ISeedProducer> plant)




let desk = [
  {
    location: 'shelf#1',
    items: [
      {
        item: 'lego flower',
        count: 2,
        type: [
          {
            name: 'tulip',
            colors: ['red', 'green', 'white'],
          },
          {
            name: 'daisy',
            colors: ['yellow', 'white', 'green'],
          },
        ],
      },
      {
        item: 'frog',
        count: 2,
        type: [
          {
            name: 'toy',
            colors: ['green'],
          },
        ],
      },
    ],
  },
  {
    location: 'undershelf#1',
    items: [
      {
        item: 'beeSquishi',
        count: 1,
        type: [
          {
            name: 'Squishi toy',
            colors: ['yellow', 'black', 'white', 'pink'],
          },
        ],
      },
    ],
  },
  {
    location: 'main desk',
    items: [
      {
        item: 'monitors',
        count: 2,
        type: [
          {
            name: 'viotek',
            colors: ['black'],
          },
          {
            name: 'imac',
            colors: ['grey', 'mint green'],
          },
        ],
      },
    ],
  },
];
// Print whole array
//console.log(desk);

// Print 1 location
//console.log(desk[0]['location']);

// Print 1 location name
//console.log(desk[0].items[1].type[0].name);

// Print 1 location items
//console.log(desk[0].items[1].item);

// Print item object
for (let i = 0; i < desk.length; i++) {
  let stuff = desk[i].items;
  for(let j = 0; j < stuff.length; j++){
    let arr = stuff[j].item
    //console.log(arr);
  }
}

// print the item object count
for (let i = 0; i < desk.length; i++) {
  let stuff = desk[i].items;
  for (let j = 0; j < stuff.length; j++) {
    let obj1 = stuff[j].count;
    //console.log(obj1);
  }
}

// print the item object name
for (let i = 0; i < desk.length; i++) {
  let result = desk[i].items;
  for (let j = 0; j < result.length; j++) {
    let res = result[j].type;
    for (let k = 0; k < res.length; k++) {
      let results = res[k].name;
      //console.log(results);
    }
  }
}

// print the colors of the object
for (let i = 0; i < desk.length; i++) {
  let result = desk[i].items;
  for (let j = 0; j < result.length; j++) {
    let res = result[j].type;
    for (let k = 0; k < res.length; k++) {
      let obj2 = res[k].colors;
      //console.log(obj2);
    }
  }
}

// print 1 color of the item

// console.log('**********************************************************')

// Print the names of all the locations

// console.log('**********************************************************')

// print the array of types for any item that has a count more than 1

// console.log('**********************************************************')

// Print all the item names if they have a color of white in the list of colors

/**
 * plugins/vuetify.js
 *
 * Framework documentation: https://vuetifyjs.com`
 */

//check out => https://www.creationsbyfaria.com/portfolio

// src/plugins/vuetify.js
import { createVuetify } from 'vuetify';
import 'vuetify/styles';
import '@mdi/font/css/materialdesignicons.css';
import { aliases, mdi } from 'vuetify/iconsets/mdi';

//Blues1
// Define the color palette
const colors = [
  { name: 'Primary', value: '#122230' },
  { name: 'Secondary', value: '#30363D' },
  { name: 'Background', value: '#0D1117' },
  { name: 'Surface', value: '#161B22' },
  { name: 'Accent', value: '#4CAF50' },
  { name: 'TextPrimary', value: '#C9D1D9'},
  { name: 'TextSecondary', value: '#8B949E'},
];

//Blues2
// Define the color palette
const colors2 = [
  { name: 'Primary2', value: '#0288D1' },
  { name: 'Secondary2', value: '#FFA726' },
  { name: 'Background2', value: '#1E1E2E' },
  { name: 'Surface2', value: '#2A2A40' },
  { name: 'Accent2', value: '#4CAF50' },
  { name: 'TextSecondary2', value: '#B0EC5'},
];

//use elsewhere
// Define the cozy color palette
const colors3 = [
  { name: 'AltPrimary3', value: '#999b84' },
  { name: 'Primary3', value: '#52796f' },
  { name: 'Secondary3', value: '#ddb7ab' },
  { name: 'AltBackground3', value: '#f4eeed' },
  { name: 'Background3', value: '#f4eeed' },
  { name: 'Surface3', value: '#efd9d1' },
  { name: 'Accent3', value: '#a17f7a' },
  { name: 'Bold3', value: '#514343' },
  { name: 'Contrast3', value: '#58D68D'},
  { name: 'Letters3', value: '#122230'},
  { name: 'Alt3', value: '#98817b'}
];

// Create the custom theme
const customTheme = {
  dark: false,
  colors: colors.reduce((acc, color) => {
    acc[color.name.toLowerCase()] = color.value;
    return acc;
  }, {}),
  colors2: colors2.reduce((acc, color) => {
    acc[color.name.toLowerCase()] = color.value;
    return acc;
  }, {}),
  colors3: colors3.reduce((acc, color) => {
    acc[color.name.toLowerCase()] = color.value;
    return acc;
  }, {}),
};

// Initialize Vuetify with the custom theme
const vuetify = createVuetify({
  theme: {
    defaultTheme: 'customTheme',
    themes: {
      customTheme,
    },
  },
  icons: {
    defaultSet: 'mdi',
    aliases,
    sets: {
      mdi,
    }
  }
});

export { colors, colors2, colors3 }; // Export the colors array for use in other components
export default vuetify;


//origional dark theme
// // https://vuetifyjs.com/en/introduction/why-vuetify/#feature-guides
// export default createVuetify({
//   theme: {
//     defaultTheme: 'dark',
//   },
// })

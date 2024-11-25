<template>
  <v-container>
    <h2>Color Palette 1</h2>
    <div v-for="color in colors" :key="color.name">
      <ColorSwatch :colorName="color.name" :colorValue="color.value" />
    </div>
  </v-container>
  <v-container>
    <h2>Color Palette 2</h2>
    <div v-for="color in colors2" :key="color.name">
      <ColorSwatch :colorName="color.name" :colorValue="color.value" />
    </div>
  </v-container>
  <v-container>
    <h2>Color Palette 3/Cozies</h2>
    <div v-for="color in colors3" :key="color.name">
      <ColorSwatch :colorName="color.name" :colorValue="color.value" />
    </div>
  </v-container>
</template>

<script setup>
import { colors, colors2, colors3 } from '@/plugins/vuetify'; // Import colors array from vuetify.js
import ColorSwatch from '@/components/ColorSwatch.vue'; // Import ColorSwatch component
</script>

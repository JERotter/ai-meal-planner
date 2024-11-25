<template>
  <v-app>
    <v-navigation-drawer
      v-model="isDrawerOpen"
      app
      color="surface"
      :permanent="false"
    >
      <v-list>
        <v-list-item title="Dashboard" />
        <v-list-item title="Profile" />
        <v-list-item title="Settings" />
        <v-list-item title="Messages" />
        <v-list-item title="Chat" />
        <v-list-item to="/login" title="Logout" router />
      </v-list>
    </v-navigation-drawer>

    <!-- App Bar -->
    <v-app-bar app color="primary" dark>
      <v-app-bar-nav-icon @click="toggleDrawer" />  <!-- Drawer Toggle Icon -->
      <v-toolbar-title>My Dashboard</v-toolbar-title>
    </v-app-bar>

    <!-- Main Content -->
    <v-main>
      <v-container fluid>

        <!-- Recent Recipess -->
        <v-row>
          <v-col cols="12">
            <h3 class="text-h5 text-left">Recent Recipes</h3>
          </v-col>
        </v-row>

        <!-- Cards Row with 6 Cards -->
        <v-row>
          <v-col cols="12" md="2" v-for="(recipe, index) in recipes" :key="index">
            <div
              class="flip-card"
              @mouseenter="hoveredCard = index"
              @mouseleave="hoveredCard = null"
            >
              <!-- Card Inner Wrapper -->
              <div class="flip-card-inner" :class="{ flipped: hoveredCard === index }">
                <!-- Front of the Card -->
                <div class="flip-card-front">
                  <v-card class="pa-4">
                    <v-img
                      :src="recipe.image"
                      alt="Card Image"
                      class="mb-2"
                      max-height="150"
                      cover
                    ></v-img>
                  </v-card>
                </div>

                <!-- Back of the Card -->
                <div class="flip-card-back">
                  <v-card class="pa-4" color="primary" dark>
                    <v-card-title>{{ recipe.name }}</v-card-title>
                    <v-card-text>{{ recipe.description }}</v-card-text>
                    <v-btn :href="recipe.link" color="accent" outlined>
                      View Recipe
                    </v-btn>
                  </v-card>
                </div>
              </div>
            </div>
          </v-col>
        </v-row>

        <!-- Data Tables Row with 2 Tables -->
        <v-row>
          <v-col cols="12" md="6">
            <v-card>
              <v-card-title>Data Table 1</v-card-title>
              <v-data-table
                :headers="headers"
                :items="items"
                class="elevation-1"
                :items-per-page="5"
              >
                <template v-slot:top>
                  <v-toolbar flat>
                    <v-toolbar-title>Table 1 Title</v-toolbar-title>
                    <v-divider class="mx-4" inset vertical></v-divider>
                    <v-spacer></v-spacer>
                    <v-text-field
                      v-model="search"
                      label="Search"
                      single-line
                      clearable
                      prepend-icon="mdi-magnify"
                    ></v-text-field>
                  </v-toolbar>
                </template>
              </v-data-table>
            </v-card>
          </v-col>
          <v-col cols="12" md="6">
            <v-card>
              <v-card-title>Data Table 2</v-card-title>
              <v-data-table
                :headers="headers"
                :items="items"
                class="elevation-1"
                :items-per-page="5"
              >
                <template v-slot:top>
                  <v-toolbar flat>
                    <v-toolbar-title>Table 2 Title</v-toolbar-title>
                    <v-divider class="mx-4" inset vertical></v-divider>
                    <v-spacer></v-spacer>
                    <v-text-field
                      v-model="search"
                      label="Search"
                      single-line
                      clearable
                      prepend-icon="mdi-magnify"
                    ></v-text-field>
                  </v-toolbar>
                </template>
              </v-data-table>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';

// Table Data
const headers = [
  { text: 'Name', value: 'name' },
  { text: 'Email', value: 'email' },
  { text: 'Role', value: 'role' },
];

const items = [
  { name: 'Alice', email: 'alice@example.com', role: 'Admin' },
  { name: 'Bob', email: 'bob@example.com', role: 'Editor' },
  { name: 'Charlie', email: 'charlie@example.com', role: 'Viewer' },
  { name: 'David', email: 'david@example.com', role: 'Admin' },
  { name: 'Eve', email: 'eve@example.com', role: 'Editor' },
];

const search = ref('');

const isDrawerOpen = ref(true);  // Tracks the state of the drawer (open or closed)

// Toggle function for the drawer
function toggleDrawer() {
  isDrawerOpen.value = !isDrawerOpen.value;
}

const recipes = [
  {
    name: "Recipe 1",
    description: "Spaghetti bolognese",
    image: new URL("../assets/images/image1.jpg", import.meta.url).href,
    link: "/recipe1",
  },
  {
    name: "Recipe 2",
    description: "Keto eggs & avocado",
    image: new URL("../assets/images/image2.jpg", import.meta.url).href,
    link: "/recipe2",
  },
  {
    name: "Recipe 3",
    description: "Vietnamese meatballs",
    image: new URL("../assets/images/image3.jpg", import.meta.url).href,
    link: "/recipe2",
  },
  {
    name: "Recipe 4",
    description: "Italian Shakshuka",
    image: new URL("../assets/images/image4.jpg", import.meta.url).href,
    link: "/recipe2",
  },
  {
    name: "Recipe 5",
    description: "Spicy braised pork",
    image: new URL("../assets/images/image5.jpg", import.meta.url).href,
    link: "/recipe2",
  },
  {
    name: "Recipe 6",
    description: "Baghali Ghatoog",
    image: new URL("../assets/images/image6.jpg", import.meta.url).href,
    link: "/recipe2",
  },
];

const hoveredCard = ref(null); // Tracks which card is hovered
</script>

<style scoped>
.v-application {
  font-family: 'Roboto', sans-serif;
}

.v-data-table {
  position: relative;
}

/* Add spacing between rows */
.v-row {
  margin-bottom: 32px;
}

.flip-card {
  perspective: 1000px;
  z-index: 1; /* Ensure cards are above */
  position: relative; /* Required for z-index */
  height: 200px; /* Set a consistent height for the card container */
}

.flip-card-inner {
  position: relative;
  width: 100%;
  height: 100%;
  transition: transform 0.6s;
  transform-style: preserve-3d;
}

.flip-card-inner.flipped {
  transform: rotateY(180deg);
}

.flip-card-front,
.flip-card-back {
  position: absolute;
  width: 100%;
  height: 100%;
  backface-visibility: hidden;
}

.flip-card-front {
  z-index: 2;
}

.flip-card-back {
  transform: rotateY(180deg);
}
</style>

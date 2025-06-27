<template>
  <v-app>
    <v-navigation-drawer
      v-model="isDrawerOpen"
      app
      color="surface"
      :permanent="false"
    >
    <v-img
          src="@/assets/logo-white.png"
          alt="A.I. Meal Planner Logo"
          height="80"
          max-width="200"
          cover
          class="logo-img"
        />
      <v-list>
        <v-list-item title="Dashboard" />
        <v-list-item title="Profile" />
        <v-list-item title="Settings" />
        <v-list-item title="Messages" />
        <v-list-item title="Chat" />
        <v-list-item to="/app/login" title="Logout" @click="logout" />
      </v-list>
    </v-navigation-drawer>


  <v-app-bar app color="primary" dark>
    <v-app-bar-nav-icon @click="toggleDrawer" /> <!-- Drawer Toggle Icon -->
    <v-toolbar-title>My Dashboard</v-toolbar-title>

    <!-- Spacer to push profile to the right -->
    <v-spacer></v-spacer>

    <!-- Notification Bell Icon -->
    <v-btn to="/app/inbox" icon>
      <v-badge color="red" content="3" overlap> <!-- Example: 3 new notifications -->
        <v-icon>mdi-bell</v-icon>
      </v-badge>
    </v-btn>

    <!-- Profile Picture with Menu -->
    <v-menu offset-y>
      <template v-slot:activator="{ props }">
        <v-btn v-bind="props" class="d-flex align-center" text>
          <v-avatar size="40">
            <v-img src="@/assets/profile.jpg" alt="Profile Picture" />
          </v-avatar>
          <span class="ml-2 text-white text-decoration-underline">{{ userName }}</span>
        </v-btn>
      </template>
      <v-list>
        <v-list-item to="/profile">
          <v-list-item-title>Profile</v-list-item-title>
        </v-list-item>
        <v-list-item to="/settings">
          <v-list-item-title>Settings</v-list-item-title>
        </v-list-item>
        <v-list-item to="/app/login" @click="logout">
          <v-list-item-title>Logout</v-list-item-title>
        </v-list-item>
      </v-list>
    </v-menu>
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
          <!-- LEFT SIDE: Regular Vuetify Data Table -->
          <v-col cols="12" md="6">
            <v-card>
              <v-card-title>Vuetify Data Table (Users)</v-card-title>
              <v-data-table
                :headers="headers"
                :items="userStore.users"
                class="elevation-1"
                :items-per-page="5"
              >
                <template v-slot:top>
                  <v-toolbar flat>
                    <v-toolbar-title>Regular Vuetify Table</v-toolbar-title>
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

          <!-- RIGHT SIDE: Vue-Good-Table -->
          <v-col cols="12" md="6">
            <v-card>
              <v-card-title>Vue-Good-Table (Sample Data)</v-card-title>
              <div class="pa-4">
                <vue-good-table
                  :columns="vueGoodTableColumns"
                  :rows="vueGoodTableRows"
                  :search-options="{
                    enabled: true,
                    placeholder: 'Search this table',
                  }"
                  :pagination-options="{
                    enabled: true,
                    perPage: 5,
                    perPageDropdown: [5, 10, 15],
                    dropdownAllowAll: false,
                  }"
                  styleClass="vgt-table striped"
                />
              </div>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';
import { onMounted } from 'vue';
import { useRouter } from 'vue-router';
import { useAuthStore } from '@/stores/auth';
import { useUserStore } from '@/stores/users';

const userStore = useUserStore()
// Fetch users when the component mounts
onMounted(() => {
  userStore.fetchUsers()
})

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

function logout() {
  const authStore = useAuthStore()
  const router = useRouter()
  authStore.logOut()  // set isLoggedIn = false
  router.push('/app/login')
}

const userName = ref("Weasel");

// Vue-Good-Table configuration
const vueGoodTableColumns = ref([
  {
    label: 'Name',
    field: 'name',
    sortable: true,
  },
  {
    label: 'Age',
    field: 'age',
    type: 'number',
    sortable: true,
  },
  {
    label: 'Created On',
    field: 'createdAt',
    type: 'date',
    dateInputFormat: 'yyyy-MM-dd',
    dateOutputFormat: 'MMM do yy',
    sortable: true,
  },
  {
    label: 'Percent',
    field: 'score',
    type: 'percentage',
    sortable: true,
  },
]);

const vueGoodTableRows = ref([
  { id: 1, name: "John", age: 20, createdAt: null, score: 0.03343 },
  { id: 2, name: "Jane", age: 24, createdAt: '2011-10-31', score: 0.03343 },
  { id: 3, name: "Susan", age: 16, createdAt: '2011-10-30', score: 0.03343 },
  { id: 4, name: "Chris", age: 55, createdAt: '2011-10-11', score: 0.03343 },
  { id: 5, name: "Dan", age: 40, createdAt: '2011-10-21', score: 0.03343 },
  { id: 6, name: "John", age: 20, createdAt: '2011-10-31', score: 0.03343 },
  { id: 7, name: "Alice", age: 28, createdAt: '2012-05-15', score: 0.08921 },
  { id: 8, name: "Bob", age: 32, createdAt: '2010-12-03', score: 0.12456 },
]);

</script>

<script>
export default {
  data() {
    return {
      headers: [
        { text: 'FirstName', value: 'firstName' },
        { text: 'LastName', value: 'lastName' },
        { text: 'Email', value: 'email' },
        { text: 'Username', value: 'userName' },
        { text: 'Id', value: 'id' }
      ]
    }
  }
}
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

/* Vue-Good-Table styling tweaks */
.vgt-table {
  border: none !important;
}

.vgt-table th {
  background-color: #f5f5f5;
  font-weight: 600;
}
</style>

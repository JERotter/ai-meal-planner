<template>
  <v-app>
    <!-- Navigation Drawer -->
    <v-navigation-drawer v-model="isDrawerOpen" app color="surface">
      <v-list>
        <v-list-item to="/app/admin" title="Dashboard" />
        <v-list-item title="Inbox" />
        <v-list-item title="Drafts" />
        <v-list-item title="Deleted" />
        <v-list-item to="/app/login" title="Logout" @click="logout" />
      </v-list>
    </v-navigation-drawer>

    <!-- App Bar -->
    <v-app-bar app color="primary" dark>
      <v-app-bar-nav-icon @click="toggleDrawer" /> <!-- Drawer Toggle Icon -->
      <v-toolbar-title>Inbox</v-toolbar-title>

      <v-spacer></v-spacer>

      <!-- Notifications -->
      <v-btn to="/app/notifications/inbox" icon>
        <v-badge color="red" content="3" overlap>
          <v-icon>mdi-bell</v-icon>
        </v-badge>
      </v-btn>

      <!-- Profile Menu -->
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
          <v-list-item @click="logout">
            <v-list-item-title>Logout</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>

    <!-- Main Content -->
    <v-main>
      <v-container class="py-8 px-6" fluid>
        <!-- White Avatar Section (Kept) -->
        <v-sheet class="pa-4 mb-4" color="grey-lighten-4">
          <v-avatar class="mb-2" color="grey-darken-1" size="64"></v-avatar>
          <div>{{ userEmail }}</div>
        </v-sheet>

        <v-row>
          <v-col v-for="(group, index) in messages" :key="index" cols="12">
            <v-card>
              <v-list>
                <v-list-subheader>{{ group.date }}</v-list-subheader>

                <template v-for="(message, msgIndex) in group.items" :key="msgIndex">
                  <v-list-item @click="toggleMessage(group.date, msgIndex)">
                    <template v-slot:prepend>
                      <v-avatar color="grey-darken-1"></v-avatar>
                    </template>

                    <v-list-item-title>{{ message.sender }}</v-list-item-title>
                    <v-list-item-subtitle>{{ message.preview }}</v-list-item-subtitle>
                  </v-list-item>

                  <v-expand-transition>
                    <div v-if="message.expanded" class="px-4 py-2">
                      <p>{{ message.fullText }}</p>
                      <v-btn small color="primary" @click="reply(message)">Reply</v-btn>
                      <v-btn small color="red" class="ml-2" @click="deleteMessage(group.date, msgIndex)">Delete</v-btn>
                    </div>
                  </v-expand-transition>

                  <v-divider v-if="msgIndex !== group.items.length - 1"></v-divider>
                </template>
              </v-list>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>

<script setup>
import { ref } from "vue";

// Drawer state
const isDrawerOpen = ref(false);

// User info
const userName = ref("weasel");
const userEmail = ref("weezy@google.com");

// Sample messages
const messages = ref([
  {
    date: "Today",
    items: [
      {
        sender: "Alice",
        preview: "Hey! How are you?",
        fullText: "Hey! How are you? I wanted to catch up about the project.",
        expanded: false,
      },
      {
        sender: "Bob",
        preview: "Meeting at 3 PM",
        fullText: "Reminder: We have a meeting at 3 PM. See you there!",
        expanded: false,
      },
    ],
  },
  {
    date: "Yesterday",
    items: [
      {
        sender: "Charlie",
        preview: "Can you send me the report?",
        fullText: "Hey, I need the latest project report. Can you send it to me?",
        expanded: false,
      },
    ],
  },
]);

// Toggle drawer function
const toggleDrawer = () => {
  isDrawerOpen.value = !isDrawerOpen.value;
};

// Expand/collapse messages
const toggleMessage = (date, index) => {
  const group = messages.value.find((g) => g.date === date);
  group.items[index].expanded = !group.items[index].expanded;
};

// Handle reply action
const reply = (message) => {
  console.log(`Replying to ${message.sender}:`, message.fullText);
};

// Delete a message
const deleteMessage = (date, index) => {
  const group = messages.value.find((g) => g.date === date);
  group.items.splice(index, 1);
};

// Logout function (stub)
const logout = () => {
  console.log("Logging out...");
};
</script>

<style>
/* Custom styling */
.v-list-item {
  cursor: pointer;
}

.v-list-item:hover {
  background-color: rgba(0, 0, 0, 0.05);
}
</style>

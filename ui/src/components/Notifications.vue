<template>
  <v-app>
    <v-navigation-drawer
      v-model="isDrawerOpen"
      app
      color="surface"
      :permanent="false"
    >
      <v-list>
        <v-list-item to="/app/admin" title="Dashboard" />
        <v-list-item title="Inbox" />
        <v-list-item title="Drafts" />
        <v-list-item title="Messages" />
        <v-list-item title="Chat" />
        <v-list-item to="/app/login" title="Logout" @click="logout" />
      </v-list>
    </v-navigation-drawer>

    <!-- App Bar -->
    <v-app-bar app color="primary" dark>
      <v-app-bar-nav-icon @click="toggleDrawer" /> <!-- Drawer Toggle Icon -->
      <v-toolbar-title>Messages</v-toolbar-title>

      <!-- Spacer to push profile to the right -->
      <v-spacer></v-spacer>

      <!-- Notification Bell Icon -->
      <v-btn to="/app/notifications" icon>
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
          <v-list-item @click="logout">
            <v-list-item-title>Logout</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>

    <div class="inbox-container">
      <h2>Messages</h2>
      <div class="messages-list">
        <div v-for="message in messages" :key="message.id" class="message">
          <p><strong>{{ message.sender }}:</strong> {{ message.text }}</p>
          <div class="actions">
            <button @click="reply(message)">Reply</button>
            <button @click="deleteMessage(message.id)" class="delete-btn">Delete</button>
          </div>
        </div>
      </div>

      <div v-if="selectedMessage" class="reply-box">
        <h3>Reply to {{ selectedMessage.sender }}</h3>
        <textarea v-model="replyText" placeholder="Type your reply..."></textarea>
        <button @click="sendReply">Send</button>
        <button @click="cancelReply" class="cancel-btn">Cancel</button>
      </div>
    </div>
  </v-app>
</template>

<script>
import { ref } from 'vue';

export default {
  setup() {
    const messages = ref([
      { id: 1, sender: "Alice", text: "Hey! How are you?" },
      { id: 2, sender: "Bob", text: "Reminder: Meeting at 3 PM" },
      { id: 3, sender: "Charlie", text: "Can you send me the report?" }
    ]);

    const selectedMessage = ref(null);
    const replyText = ref("");

    const deleteMessage = (id) => {
      messages.value = messages.value.filter(msg => msg.id !== id);
    };

    const reply = (message) => {
      selectedMessage.value = message;
      replyText.value = "";
    };

    const sendReply = () => {
      if (replyText.value.trim() === "") return;
      console.log(`Replying to ${selectedMessage.value.sender}:`, replyText.value);
      cancelReply();
    };

    const cancelReply = () => {
      selectedMessage.value = null;
      replyText.value = "";
    };

    return { messages, selectedMessage, replyText, deleteMessage, reply, sendReply, cancelReply };
  }
};
</script>

<style>
.inbox-container {
  max-width: 400px;
  margin: auto;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 8px;
  background: #f9f9f9;
}

.messages-list {
  max-height: 300px;
  overflow-y: auto;
  border: 1px solid #ddd;
  padding: 10px;
  background: white;
}

.message {
  padding: 10px;
  border-bottom: 1px solid #eee;
}

.actions {
  display: flex;
  gap: 10px;
  margin-top: 5px;
}

button {
  padding: 5px 10px;
  border: none;
  cursor: pointer;
}

.delete-btn {
  background: red;
  color: white;
}

.reply-box {
  margin-top: 20px;
  padding: 10px;
  border: 1px solid #ddd;
  background: white;
}

textarea {
  width: 100%;
  height: 60px;
  margin-top: 5px;
}

.cancel-btn {
  background: gray;
  color: white;
  margin-left: 5px;
}
</style>

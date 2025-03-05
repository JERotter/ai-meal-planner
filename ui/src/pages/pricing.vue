<template>
  <div>
    <!-- Sticky Navigation Bar -->
    <v-app-bar app color="white" elevate-on-scroll>
    <v-container class="d-flex align-center">
      <v-btn text to="/" class="text-h6 font-weight-bold">A.I. Meal Planner</v-btn>
      <v-spacer></v-spacer>
      <v-btn text to="/pricing">Pricing</v-btn>
      <v-btn text to="/about">About</v-btn>
      <v-btn color="primary" to="/app/register" class="ml-3">Sign Up</v-btn>
    </v-container>
  </v-app-bar>

  <v-container class="py-12 px-6 bg-gray-100 text-gray-900">
      <h2 class="text-4xl font-bold text-center mb-12">Choose Your Plan</h2>
      <v-row class="justify-center">
        <!-- Free Plan -->
        <v-col cols="12" md="4">
          <v-card class="bg-white p-6 rounded-lg shadow-md text-center">
            <h3 class="text-2xl font-bold">Free</h3>
            <p class="text-gray-600 mt-2">For casual users</p>
            <p class="text-4xl font-bold text-gray-800 mt-4">$0<span class="text-lg">/mo</span></p>
            <ul class="mt-4 space-y-2 text-gray-700">
              <li>✔ Basic meal planning</li>
              <li>✔ Limited customization</li>
              <li>✔ Community support</li>
            </ul>
            <v-btn color="orange" class="mt-6">Get Started</v-btn>
          </v-card>
        </v-col>

        <!-- Premium Plan -->
        <v-col cols="12" md="4">
          <v-card class="bg-orange-100 p-6 rounded-lg shadow-lg text-center border-2 border-orange-500">
            <h3 class="text-2xl font-bold">Premium</h3>
            <p class="text-gray-600 mt-2">For dedicated meal planners</p>
            <p class="text-4xl font-bold text-gray-800 mt-4">$9<span class="text-lg">/mo</span></p>
            <ul class="mt-4 space-y-2 text-gray-700">
              <li>✔ Advanced meal customization</li>
              <li>✔ Grocery list integration</li>
              <li>✔ Email support</li>
            </ul>
            <v-btn color="orange" class="mt-6">Upgrade</v-btn>
          </v-card>
        </v-col>

        <!-- Pro Plan -->
        <v-col cols="12" md="4">
          <v-card class="bg-white p-6 rounded-lg shadow-md text-center">
            <h3 class="text-2xl font-bold">Pro</h3>
            <p class="text-gray-600 mt-2">For professionals and families</p>
            <p class="text-4xl font-bold text-gray-800 mt-4">$19<span class="text-lg">/mo</span></p>
            <ul class="mt-4 space-y-2 text-gray-700">
              <li>✔ Unlimited meal planning</li>
              <li>✔ AI-powered recommendations</li>
              <li>✔ Priority customer support</li>
            </ul>
            <v-btn color="orange" class="mt-6">Go Pro</v-btn>
          </v-card>
        </v-col>
      </v-row>
  </v-container>

  <!-- Footer -->
  <v-footer class="bg-grey-darken-4 text-white text-center py-3">
      <p>&copy; 2024 SmartMealPlanner. All rights reserved.</p>
    </v-footer>
    <!-- Footer -->
    <footer class="py-6 bg-gray-900 text-white text-center">
      <p>&copy; 2024 Eat This Much Clone. All rights reserved.</p>
    </footer>

</div>
</template>

<script>
export default {
  name: "PricingPage",
};
</script>

<style scoped>
.v-card {
  transition: transform 0.3s;
}

.v-card:hover {
  transform: scale(1.05);
}
</style>

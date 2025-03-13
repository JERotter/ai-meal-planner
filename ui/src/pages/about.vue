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
      <!-- Section 1: Health Issues & Need for Better Eating -->
      <h2 class="text-3xl font-bold text-center mb-6">The State of American Health</h2>
      <p class="text-lg text-center max-w-3xl mx-auto mb-6">
        In the United States, chronic illnesses like diabetes, obesity, and heart disease are on the rise.
        With the overwhelming availability of ultra-processed foods and busy lifestyles, many struggle to maintain
        a balanced diet. But eating well shouldn’t be complicated. That’s why we built <strong>PeriPeri AI Meal Planner</strong>—
        a simple, intelligent way to plan meals that align with your health goals.
      </p>
    </v-container>

    <v-container class="py-12 px-6 bg-gray-200 text-gray-900">
      <!-- Section 2: Philosophy Behind PeriPeri AI Meal Planner -->
      <h2 class="text-3xl font-bold text-center mb-6">Our Philosophy</h2>
      <p class="text-lg text-center max-w-3xl mx-auto mb-6">
        Food should nourish you, fuel your body, and bring joy—not stress. I created PeriPeri AI Meal Planner
        to help individuals take the guesswork out of meal planning. Our goal is to provide **smart, easy, and
        customizable** meal plans based on real food, personal preferences, and dietary needs. We believe that
        better eating leads to a better life, and everyone deserves access to tools that make that possible.
      </p>
    </v-container>

    <v-container class="py-12 px-6 bg-gray-300 text-gray-900">
      <!-- Section 3: Team Members -->
      <h2 class="text-3xl font-bold text-center mb-6">Meet the Team</h2>
      <v-row class="justify-center">
        <v-col cols="12" md="4" class="text-center">
          <v-img src="../assets/images/team/founder.jpg" class="rounded-lg mx-auto" width="200" height="250" />
          <h3 class="text-xl font-semibold mt-4">[Your Name]</h3>
          <p class="text-gray-700">Founder & Developer</p>
          <p class="text-gray-600 text-sm mt-2">Passionate about tech, food, and making meal planning smarter for everyone.</p>
        </v-col>

        <v-col cols="12" md="4" class="text-center">
          <v-img src="../assets/images/team/contributor1.jpg" class="rounded-lg mx-auto" width="200" height="250" />
          <h3 class="text-xl font-semibold mt-4">Jamie Taylor</h3>
          <p class="text-gray-700">Nutrition Consultant</p>
          <p class="text-gray-600 text-sm mt-2">Dedicated to making healthy eating accessible and simple for busy lives.</p>
        </v-col>

        <v-col cols="12" md="4" class="text-center">
          <v-img src="../assets/images/team/contributor2.jpg" class="rounded-lg mx-auto" width="200" height="250" />
          <h3 class="text-xl font-semibold mt-4">Alex Martinez</h3>
          <p class="text-gray-700">AI & Data Specialist</p>
          <p class="text-gray-600 text-sm mt-2">Bringing cutting-edge AI to revolutionize meal planning.</p>
        </v-col>
      </v-row>
    </v-container>

    <!-- Footer -->
    <v-footer class="bg-grey-darken-4 text-white justify-center py-3">
      <p>&copy; 2025 Per~Peri. All rights reserved.</p>
    </v-footer>
    <footer class="py-6 bg-gray-900 text-white text-center">
    </footer>
    <AppFooter/>
  </div>
</template>

<script>
export default {
  name: "AboutPage",
};
</script>

<style scoped>
.v-container {
  max-width: 1200px;
  margin: 0 auto;
}
</style>

<template>
  <div>
     <!-- Sticky Navigation Bar -->
     <v-app-bar app color="white" elevate-on-scroll>
      <v-container class="d-flex align-center">
        <v-btn to="/" class="pa-0" height= "150" width="150" style="color:white">
          <v-img src="@/assets/logo-black.png" alt="A.I. Meal Planner Logo" contain />
        </v-btn>

        <v-spacer></v-spacer>
        <v-btn text @click="scrollTo('how-it-works')">How It Works</v-btn>
        <v-btn text @click="scrollTo('testimonials')">Testimonials</v-btn>
        <v-btn text to="/pricing">Pricing</v-btn>
        <v-btn text to="/about">About</v-btn>
        <v-btn color="primary" to="/app/register" class="ml-3">Sign Up</v-btn>
      </v-container>
    </v-app-bar>

    <!-- Hero Section -->
    <v-container fluid class="text-center bg-gradient" id="hero">
      <v-row justify="center">
        <v-col cols="12" md="8">
          <h1 class="text-h3 font-weight-bold text-white">Effortless Meal Planning</h1>
          <p class="text-h6 text-white mt-3">
            Automatically generate meal plans tailored to your goals
          </p>
          <v-btn color="white" class="mt-5" @click="generateMeals">
            Generate a Meal Plan
          </v-btn>
        </v-col>
      </v-row>
    </v-container>
    <v-container class="py-6 px-4">
    <h2 class="text-3xl font-bold mb-6 text-center">Frequently Asked Questions</h2>

    <v-expansion-panels>
      <v-expansion-panel v-for="(faq, index) in faqs" :key="index">
        <v-expansion-panel-title>
          {{ faq.question }}
        </v-expansion-panel-title>
        <v-expansion-panel-text>
          {{ faq.answer }}
        </v-expansion-panel-text>
      </v-expansion-panel>
    </v-expansion-panels>
  </v-container>
  
  <!-- Footer -->
  <v-footer class="bg-grey-darken-4 text-white justify-center py-3">
      <p>&copy; 2025 Per~Peri. All rights reserved.</p>
    </v-footer>
    <footer class="py-6 bg-gray-900 text-white text-center">
    </footer>
    <AppFooter />
  </div>
</template>

<script setup>
import { ref } from 'vue';
import AppFooter from '@/components/AppFooter.vue';

const faqs = ref([
  { question: "What is Peri~Peri AI Meal Planner?", answer: "Peri~Peri is an AI-powered meal planner that generates customized meal plans based on your dietary goals, preferences, and restrictions." },
  { question: "How does the AI generate meals?", answer: "Our AI analyzes your input—such as goals, allergies, and preferences—to create a variety of balanced meals tailored to you." },
  { question: "Is Peri~Peri free to use?", answer: "We offer a free plan with essential features, and premium options for advanced customization and tracking." },
  { question: "Can I track my calorie intake?", answer: "Yes! Peri~Peri provides detailed nutritional breakdowns to help you track your intake and stay on target." },
  { question: "Can I customize the meal plans?", answer: "Absolutely! You can swap meals, adjust portions, and personalize your meal plans to fit your lifestyle." },
  { question: "Does Peri~Peri support different diets?", answer: "Yes, we support keto, paleo, vegan, carnivore, and more! Just set your preferences in the app." },
  { question: "Can I generate shopping lists?", answer: "Yes! Peri~Peri automatically creates shopping lists based on your selected meals." },
  { question: "Is there a mobile app available?", answer: "Not yet, but we're working on it! Stay tuned for future updates." },
  { question: "How do I get started?", answer: "Simply sign up, set your goals, and let Peri~Peri generate your personalized meal plan!" },
  { question: "How can I contact support?", answer: "You can reach us via our support page or email us at support@periperimeals.com." }
]);

</script>
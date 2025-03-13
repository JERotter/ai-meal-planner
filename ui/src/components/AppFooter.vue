<template>
  <footer class="footer">
    <div class="footer-container">

      <!-- Newsletter Section -->
      <div class="newsletter">
        <v-img
          src="@/assets/logo-white.png"
          alt="A.I. Meal Planner Logo"
          height="80"
          max-width="200"
          cover
          class="logo-img"
        />
        <h3>Join My Newsletter</h3>
        <p>Subscribe to stay updated with the latest news and exclusive content.</p>
        <div class="newsletter-form">
          <input type="email" v-model="email" placeholder="Enter your email" />
          <button @click="subscribe">Subscribe</button>
        </div>
      </div>

      <!-- Footer Links -->
      <div class="footer-links">
        <div v-for="(category, index) in linkCategories" :key="index" class="link-group">
          <h4>{{ category.title }}</h4>
          <ul>
            <li v-for="(link, i) in category.links" :key="i">
              <a :href="link.url">{{ link.text }}</a>
            </li>
          </ul>
        </div>
      </div>

      <!-- Social Media Icons -->
      <div class="social-media">
        <h4>Follow Me</h4>
          <div class="icons">
            <a v-for="(icon, index) in socialLinks"
              :key="index"
              :href="icon.url"
              target="_blank"
              rel="noopener noreferrer"
              :title="icon.name">
              <svg :viewBox="icon.viewBox" class="social-icon">
                <path :d="icon.path"></path>
              </svg>
            </a>
          </div>
      </div>
    </div>

    <div class="footer-bottom">
      <p>Peri~Peri © 2025. All rights reserved.</p>
    </div>
  </footer>
</template>

<script>
import { ref } from "vue";

export default {
  setup() {
    const email = ref("");

    const subscribe = () => {
      if (!email.value.trim()) return;
      console.log("Subscribed with email:", email.value);
      email.value = "";
    };

    const linkCategories = ref([
      {
        title: "Company",
        links: [
          { text: "About Us", url: "#" },
          { text: "Careers", url: "#" },
          { text: "Press", url: "#" },
        ],
      },
      {
        title: "Support",
        links: [
          { text: "Help Center", url: "#" },
          { text: "Contact Us", url: "#" },
          { text: "FAQs", url: "/questions" },
        ],
      },
      {
        title: "Legal",
        links: [
          { text: "Privacy Policy", url: "#" },
          { text: "Terms of Service", url: "#" },
          { text: "Cookie Policy", url: "#" },
        ],
      },
    ]);

    const socialLinks = ref([
      {
        name: "Twitter",
        url: "https://Twitter.com",
        viewBox: "0 0 24 24",
        path: "M22.46 6c-.77.35-1.6.58-2.46.69a4.16 4.16 0 0 0 1.82-2.32 8.24 8.24 0 0 1-2.63 1.01 4.13 4.13 0 0 0-7 3.77A11.71 11.71 0 0 1 3.06 4.6a4.13 4.13 0 0 0 1.28 5.51 4.1 4.1 0 0 1-1.87-.52v.05a4.13 4.13 0 0 0 3.31 4.06 4.17 4.17 0 0 1-1.86.07 4.14 4.14 0 0 0 3.86 2.87A8.3 8.3 0 0 1 2 18.58a11.72 11.72 0 0 0 6.29 1.84c7.54 0 11.67-6.25 11.67-11.67 0-.18-.01-.36-.02-.53A8.29 8.29 0 0 0 22.46 6z",
      },
      {
        name: "Facebook",
        url: "https://Facebook.com",
        viewBox: "0 0 24 24",
        path: "M22 12a10 10 0 1 0-11.5 9.9v-7h-2v-3h2v-2.3c0-2 1.2-3 3-3 .9 0 1.8.1 2 .1v2h-1.4c-1.1 0-1.6.7-1.6 1.5V12h3l-.5 3h-2.5v7A10 10 0 0 0 22 12z",
      },
      {
        name: "Instagram",
        url: "https://Instagram.com",
        viewBox: "0 0 24 24",
        path: "M7 2C4.2 2 2 4.2 2 7v10c0 2.8 2.2 5 5 5h10c2.8 0 5-2.2 5-5V7c0-2.8-2.2-5-5-5H7zm10 2c1.7 0 3 1.3 3 3v10c0 1.7-1.3 3-3 3H7c-1.7 0-3-1.3-3-3V7c0-1.7 1.3-3 3-3h10zM12 7a5 5 0 1 0 0 10 5 5 0 0 0 0-10zm0 2a3 3 0 1 1 0 6 3 3 0 0 1 0-6zm4.5-.5a1.2 1.2 0 1 0 0 2.4 1.2 1.2 0 0 0 0-2.4z",
      },
      {
        name: 'GitHub',
        url: "https://github.com/JERotter",
        viewBox: "0 0 24 24",
        path: "M12 2C6.48 2 2 6.48 2 12c0 4.42 2.87 8.17 6.84 9.49.5.09.66-.21.66-.47 0-.23-.01-.82-.01-1.61-2.78.61-3.37-1.34-3.37-1.34-.46-1.18-1.12-1.5-1.12-1.5-.91-.62.07-.61.07-.61 1 .07 1.52 1.03 1.52 1.03 .9 1.54 2.36 1.1 2.94.84.09-.65.35-1.1.63-1.35-2.22-.25-4.56-1.11-4.56-4.94 0-1.09.39-1.98 1.03-2.68-.1-.25-.45-1.28.1-2.66 0 0 .84-.27 2.75 1.02A9.58 9.58 0 0 1 12 6.8c.85 0 1.71.11 2.51.33 1.91-1.29 2.75-1.02 2.75-1.02 .55 1.38.2 2.41.1 2.66 .64.7 1.03 1.59 1.03 2.68 0 3.85-2.34 4.69-4.57 4.94 .36.31.67.92.67 1.86 0 1.35-.01 2.43-.01 2.76 0 .26.16.56.67.47A10.02 10.02 0 0 0 22 12c0-5.52-4.48-10-10-10Z",
    },
    ]);

    return { email, subscribe, linkCategories, socialLinks };
  },
};
</script>

<style>
.footer {
  background: #1d2530;
  color: #fff;
  padding: 40px 20px;
}

.footer-container {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 30px;
  max-width: 1100px;
  margin: auto;
  margin-right: 7%;
}

.logo-img {
  margin-top: -25px;
}

.newsletter h3,
.footer-links h4,
.social-media h4 {
  margin-bottom: 15px;
}

.newsletter-form {
  display: flex;
  gap: 10px;
  margin-top: 10px;
}

.newsletter-form input {
  flex: 1;
  padding: 10px;
  border: none;
  border-radius: 5px;
}

.newsletter-form button {
  padding: 10px;
  border: none;
  background: #f90;
  color: #fff;
  cursor: pointer;
  border-radius: 5px;
}

.footer-links {
  display: flex;
  justify-content: space-between;
}

.link-group ul {
  list-style: none;
  padding: 0;
}

.link-group a {
  color: #ccc;
  text-decoration: none;
  display: block;
  margin-bottom: 5px;
}

.social-media .icons {
  display: flex;
  gap: 10px;
}

.social-icon {
  width: 24px;
  height: 24px;
  fill: #ccc;
}

.footer-bottom {
  text-align: center;
  margin-top: 20px;
}
</style>

<template>
  <div class="color-swatch">
    <div :style="{ backgroundColor: colorValue }" class="swatch-square"></div>
    <span class="color-name">{{ colorName }}: {{ colorValue }}</span>
  </div>
</template>

<script setup>
defineProps({
  colorName: String,
  colorValue: String,
});
</script>

<style scoped>
.color-swatch {
  display: flex;
  align-items: center;
  margin-bottom: 8px;
}
.swatch-square {
  width: 20px;
  height: 20px;
  border-radius: 3px;
  margin-right: 8px;
  border: 1px solid #ccc;
}
.color-name {
  font-size: 14px;
}
</style>

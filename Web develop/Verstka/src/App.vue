<template>

  <RouterView />
  <WebVue />
</template>

<script setup>
import { RouterLink, RouterView } from 'vue-router'
import HomeView from './views/HomeView.vue';
import WebVue from './views/WebVue.vue';
</script>



<style scoped>

</style>

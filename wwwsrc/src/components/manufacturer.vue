<template>
  <div class="manufacturer col-2">
    <div class="border p-1 text-center">
      <p>{{ manufacturer.name }}</p>
      <img class="home-img" :src="manufacturer.img" alt="">
    </div>
  </div>
</template>


<script>
export default {
  name: "manufacturer",
  props: ["manufacturer"],
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {},
};
</script>


<style scoped>
</style> 
<template>
  <div class="manufacturer">
    <div class="card bg-light">
      <p>{{ manufacturer.name }}</p>
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
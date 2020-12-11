<template>
  <div class="lineSlide col-2">
    <div class="border p-1 text-center">
      <h5>{{ lineSlide.name }}</h5>
      <img class="home-img" :src="lineSlide.img" alt="">
        <div class="row justify-content-center">
      <button class="btn btn-outline-info col-4 m-1" @click="addToRig(lineSlide.id)">
        Own
      </button>
      <button class="btn btn-outline-info col-4 m-1">
        Want
      </button>
        
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "lineSlide",
  props: ["lineSlide"],
  data() {
    return {};
  },
  computed: {},
  methods: {
    addLineSlideToRig(lineSlideID) {
      this.$store.commit("addToRig", {
        lineSlideId: lineSlideID,
        rigId: "3",
        userId: this.$store.state.user.sub,
      });
    },
  },
  components: {},
};
</script>


<style scoped>
</style>
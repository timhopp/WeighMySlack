<template>
  <div class="wbbingGrips col-2">
    <div class="border p-1 text-center">
      <p>{{ webbingGrip.name }}</p>
      <img class=" home-img" :src="webbingGrip.img" alt="">
      <div class="row justify-content-center">
      <button class="btn btn-outline-info col-4 m-1" @click="addToRig(webbingGrip.id)">
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
  name: "webbingGrip",
  props: ["webbingGrip"],
  data() {
    return {};
  },
  computed: {},
  methods: {
    addwebbingGripToRig(webbingGripID) {
      this.$store.commit("addToRig", {
        webbingGripId: webbingGripID,
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
<template>
  <div class="leashRings col-2">
    <div class="border p-1 text-center">
      <p>{{ leashRings.name }}</p>
      <img class=" home-img" :src="leashRings.img" alt="">
      <div class="row justify-content-center">
      <button class="btn btn-outline-info col-4 m-1" @click="addToRig(leashRings.id)">
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
  name: "leashRings",
  props: ["leashRings"],
  data() {
    return {};
  },
  computed: {},
  methods: {
    addLeashRingsToRig(leashRingID) {
      this.$store.commit("addToRig", {
        leashRingId: leashRingID,
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
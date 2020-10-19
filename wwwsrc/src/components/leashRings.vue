<template>
  <div class="leashRings">
    <div class="card bg-light">
      <p>{{ leashRings.name }}</p>
      <button class="btn btn-info" @click="addToRig(leashRings.id)">
        Add To Rig
      </button>
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
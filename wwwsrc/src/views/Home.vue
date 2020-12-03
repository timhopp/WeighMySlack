<template>
  <div class="home">
    <h1>Welcome To Weigh My Slack</h1>
    <div class="row justify-content-center">
      <h3>Leash Rings</h3>
      <leashRings
        v-for="leashRingItem in leashRings"
        :leashRings="leashRingItem"
        :key="leashRingItem.id"
      ></leashRings>
    </div>
    <div class="row justify-content-center">
      <h3>Manufacturers</h3>
      <manufacturer
        v-for="manufacturerItem in manufacturers"
        :manufacturer="manufacturerItem"
        :key="manufacturerItem.id"
      >
      </manufacturer>
    </div>
  </div>
</template>

<script>
import leashRings from "../components/leashRings";
import manufacturer from "../components/manufacturer";
export default {
  name: "home",
  computed: {
    user() {
      return this.$store.state.user;
    },
    leashRings() {
      return this.$store.state.leashRings;
    },
    manufacturers() {
      return this.$store.state.manufacturers;
    },
  },
  mounted() {
    this.$store.dispatch("getLeashRings");
    this.$store.dispatch("getManufacturers");
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    },
  },
  components: {
    leashRings,
    manufacturer,
  },
};
</script>
